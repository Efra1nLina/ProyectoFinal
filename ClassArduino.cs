using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    class ClassArduino
    {
        private readonly string archivoRuta;
        private readonly string puerto;
        private readonly int baudRate;
        private SerialPort serialPort;

        public ClassArduino(string archivoRuta = @"C:\estadio\transacciones.txt", string puerto = "COM5", int baudRate = 9600)
        {
            this.archivoRuta = archivoRuta;
            this.puerto = puerto;
            this.baudRate = baudRate;
        }

        public async Task EnviarTransaccionesAsync()
        {
            if (!File.Exists(archivoRuta))
            {
                MessageBox.Show("No se encontró el archivo de transacciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lineas = File.ReadAllLines(archivoRuta);

            try
            {
                serialPort = new SerialPort(puerto, baudRate);
                serialPort.Open();

                foreach (string linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    serialPort.WriteLine(linea);
                    string respuesta = serialPort.ReadLine().Trim();

                    if (respuesta != "OK")
                    {
                        MessageBox.Show($"Error desde Arduino: {respuesta}");
                        return;
                    }
                }

                // Señal para indicar que se terminó de enviar
                serialPort.WriteLine("FIN");
                MessageBox.Show("Tickets enviados. Coloca tarjeta RFID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en comunicación serial: {ex.Message}");
            }
            finally
            {
                if (serialPort != null && serialPort.IsOpen)
                    serialPort.Close();
            }
        }


    }
}

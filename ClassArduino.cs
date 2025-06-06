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

        public ClassArduino(string archivoRuta = @"C:\estadio\transacciones.txt", string puerto = "COM3", int baudRate = 9600)
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
                serialPort.ReadTimeout = 5000;
                serialPort.WriteTimeout = 2000;
                serialPort.Open();

                foreach (string linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    serialPort.WriteLine(linea);
                    MessageBox.Show($"Se envió:\n{linea}\n\nAcerca una tarjeta RFID.", "Esperando...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string respuesta = serialPort.ReadLine();
                    MessageBox.Show($"Arduino respondió:\n{respuesta}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MessageBox.Show("Todas las transacciones fueron enviadas.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la comunicación serial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (serialPort != null && serialPort.IsOpen)
                    serialPort.Close();
            }
        }

    }
}

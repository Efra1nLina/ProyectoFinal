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
    public class ClassArduino
    {
        private readonly string rutaArchivo = @"C:\estadio\transacciones.txt";
        private readonly SerialPort puertoSerie;

        public ClassArduino()
        {
            puertoSerie = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One)
            {
                Handshake = Handshake.None,
                ReadTimeout = 500,
                WriteTimeout = 500
            };
        }

        public void EnviarDatos()
        {
            try
            {
                // ▶ Abrimos el puerto serie
                if (!puertoSerie.IsOpen)
                    puertoSerie.Open();

                // ▶ Verificamos que el archivo exista
                if (!File.Exists(rutaArchivo))
                {
                    MessageBox.Show("No se encontró el archivo de transacciones.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lineas = File.ReadAllLines(rutaArchivo);
                if (lineas.Length == 0)
                {
                    MessageBox.Show("El archivo de transacciones está vacío.", "Archivo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ▶ Leemos zona de la primera línea
                string[] camposPrimera = lineas[0].Split(';');
                if (camposPrimera.Length < 3)
                {
                    MessageBox.Show("La estructura de la primera línea es inválida.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string zonaObjetivo = camposPrimera[2].Trim();
                int contador = 0;

                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split(';');
                    if (campos.Length >= 3 && campos[2].Trim().Equals(zonaObjetivo, StringComparison.OrdinalIgnoreCase))
                    {
                        contador++;
                    }
                }

                string mensaje = $"{zonaObjetivo.ToUpper()}: {contador}";
                puertoSerie.WriteLine(mensaje);

                MessageBox.Show($"Datos enviados correctamente a Arduino:\n\n\"{mensaje}\"", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al enviar los datos a Arduino:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (puertoSerie.IsOpen)
                    puertoSerie.Close();
            }
        }
    }   
}
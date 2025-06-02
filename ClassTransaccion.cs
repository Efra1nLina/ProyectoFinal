using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
namespace ProyectoFinal
{
    internal class ClassTransaccion
    {
        private int contadorBoletos;
        string carpeta = @"C:\estadio";
        private readonly string rutaArchivo = @"C:\estadio\transacciones.txt";

        public ClassTransaccion()
        {
            contadorBoletos = 1;
        }

        public List<ClassBoleto> ProcesarColaConAsientos(ClassOrden orden, ClassEstadio estadio, List<int> listaAsientos)
        {
            List<ClassBoleto> boletosGenerados = new List<ClassBoleto>();
            int indexAsiento = 0;

            while (!orden.EstaVacia() && indexAsiento < listaAsientos.Count)
            {
                ClassNodoOrden? cliente = orden.Desencolar();

                if (cliente != null)
                {
                    MessageBox.Show($"Procesando cliente: {cliente.Nombre}, Zona: {cliente.ZonaDeseada}"); // Debug

                    bool disponible = estadio.VerificarDisponibilidad(cliente.ZonaDeseada, 1);

                    if (disponible)
                    {
                        bool asignado = estadio.AsignarTickets(cliente.ZonaDeseada, 1);

                        if (asignado)
                        {
                            int asientoAsignado = listaAsientos[indexAsiento];
                            ClassBoleto boleto;

                            if (cliente.ZonaDeseada.Equals("VIP", StringComparison.OrdinalIgnoreCase))
                            {
                                MessageBox.Show("Creando boleto VIP"); // Debug
                                boleto = new ClassBoletoVIP(contadorBoletos, cliente.ZonaDeseada, asientoAsignado, cliente.Nombre);
                            }
                            else
                            {
                                boleto = new ClassBoleto(contadorBoletos, cliente.ZonaDeseada, asientoAsignado, cliente.Nombre);
                            }

                            // Debug antes de guardar
                            MessageBox.Show($"Guardando boleto #{contadorBoletos} - Tipo: {(boleto is ClassBoletoVIP ? "VIP" : "Normal")}");

                            GuardarTransaccionYGenerarQR(boleto);
                            boletosGenerados.Add(boleto);
                            contadorBoletos++;
                            indexAsiento++;
                        }
                    }
                }
            }
            return boletosGenerados;
        }


        private void GuardarTransaccionYGenerarQR(ClassBoleto boleto)
        {

            try
            {
                // Verificar y crear directorio
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                    MessageBox.Show($"Directorio creado en: {carpeta}");
                }

                // Contenido QR
                string contenidoQR = $"Boleto #{boleto.Numero}\nZona: {boleto.Zona}\nAsiento: {boleto.Asiento}\nCliente: {boleto.NombreComprador}";

                // Añadir beneficios si es VIP
                if (boleto is ClassBoletoVIP vip)
                {
                    contenidoQR += $"\nBeneficios: {vip.Beneficios}";
                }

                // Guardar en archivo
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    if (boleto is ClassBoletoVIP vip2)
                    {
                        sw.WriteLine($"{vip2.Numero};{vip2.NombreComprador};{vip2.Zona};{vip2.Asiento};{vip2.FechaHoraCompra};{vip2.Beneficios}");
                        MessageBox.Show("Boleto VIP guardado en archivo");
                    }
                    else
                    {
                        sw.WriteLine($"{boleto.Numero};{boleto.NombreComprador};{boleto.Zona};{boleto.Asiento};{boleto.FechaHoraCompra}");
                    }
                }

                // Generar QR
                string rutaImagen = Path.Combine(carpeta, $"QR_{boleto.Numero}.png");

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(contenidoQR, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrImage = qrCode.GetGraphic(20);

                qrImage.Save(rutaImagen, ImageFormat.Png);
                MessageBox.Show($"QR generado en: {rutaImagen}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error crítico: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}");
            }

        }
    }

}
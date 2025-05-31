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
        private string rutaArchivo = @"C:\estadio\transacciones.txt";

        public ClassTransaccion()
        {
            contadorBoletos = 1;
        }

        public void ProcesarColaConAsientos(ClassOrden orden, ClassEstadio estadio, List<int> listaAsientos)
        {
            int indexAsiento = 0;

            while (!orden.EstaVacia() && indexAsiento < listaAsientos.Count)
            {
                ClassNodoOrden? cliente = orden.Desencolar();

                if (cliente != null)
                {
                    bool disponible = estadio.VerificarDisponibilidad(cliente.ZonaDeseada, 1);

                    if (disponible)
                    {
                        bool asignado = estadio.AsignarTickets(cliente.ZonaDeseada, 1);

                        if (asignado)
                        {
                            int asientoAsignado = listaAsientos[indexAsiento];
                            ClassBoleto boleto;

                            if (cliente.ZonaDeseada == "VIP")
                            {
                                boleto = new ClassBoletoVIP(contadorBoletos, cliente.ZonaDeseada, asientoAsignado, cliente.Nombre);
                            }
                            else
                            {
                                boleto = new ClassBoleto(contadorBoletos, cliente.ZonaDeseada, asientoAsignado, cliente.Nombre);
                            }

                            GuardarTransaccion(boleto);
                            GenerarQR(boleto);

                            MessageBox.Show("Compra realizada:\n" + boleto.ObtenerInformacion());

                            contadorBoletos++;
                            indexAsiento++;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No hay boletos disponibles en la zona {cliente.ZonaDeseada} para {cliente.Nombre}");
                    }
                }
            }
           // string rutaQR = $@"C:\estadio\QR_{boleto.Numero}.png";
            //QR vistaQR = new QR(rutaQR);
            //vistaQR.Show();

        }

        private void GuardarTransaccion(ClassBoleto boleto)
        {
            
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine($"{boleto.Numero};{boleto.NombreComprador};{boleto.Zona};{boleto.Asiento};{boleto.FechaHoraCompra}");
            }
        }

        private void GenerarQR(ClassBoleto boleto)
        {
            string carpeta = @"C:\estadio";
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            string contenidoQR = $"Boleto #{boleto.Numero}\nZona: {boleto.Zona}\nAsiento: {boleto.Asiento}\nCliente: {boleto.NombreComprador}";
            string rutaImagen = Path.Combine(carpeta, $"QR_{boleto.Numero}.png");

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(contenidoQR, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrImage = qrCode.GetGraphic(20);

            qrImage.Save(rutaImagen, ImageFormat.Png);
        }
    }
}


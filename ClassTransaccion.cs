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
                                
                                boleto = new ClassBoletoVIP(contadorBoletos, cliente.ZonaDeseada, asientoAsignado, cliente.Nombre);
                            }
                            else
                            {
                                
                                boleto = new ClassBoleto(contadorBoletos, cliente.ZonaDeseada, asientoAsignado, cliente.Nombre);
                            }


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

            MessageBox.Show("Entrando a GuardarTransaccionYGenerarQR");

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }
            string contenidoQR = $"Boleto #{boleto.Numero}\nZona: {boleto.Zona}\nAsiento: {boleto.Asiento}\nCliente: {boleto.NombreComprador}";
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    if (boleto is ClassBoletoVIP vip)
                    {
                        sw.WriteLine($"{vip.Numero};{vip.NombreComprador};{vip.Zona};{vip.Asiento};{vip.FechaHoraCompra};{vip.Beneficios}");
                    }
                    else
                    {
                        sw.WriteLine($"{boleto.Numero};{boleto.NombreComprador};{boleto.Zona};{boleto.Asiento};{boleto.FechaHoraCompra}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }

            //Para el QR

            string rutaImagen = Path.Combine(carpeta, $"QR_{boleto.Numero}.png");

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(contenidoQR, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrImage = qrCode.GetGraphic(20);
            qrImage.Save(rutaImagen, ImageFormat.Png);
        }

       
    }
}


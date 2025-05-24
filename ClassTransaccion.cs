using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class ClassTransaccion
    {
        private int contadorBoletos;
        private readonly string rutaArchivo = "transacciones.txt";

        public ClassTransaccion()
        {
            contadorBoletos = 1;
        }

        public void ProcesarCola(ClassOrden orden, ClassEstadio estadio)
        {
            while (!orden.EstaVacia())
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
                           ClassBoleto boleto;

                            if (cliente.ZonaDeseada == "VIP")
                            {
                                boleto = new ClassBoletoVIP(contadorBoletos, cliente.ZonaDeseada, contadorBoletos, cliente.Nombre);
                            }
                            else
                            {
                                boleto = new ClassBoleto(contadorBoletos, cliente.ZonaDeseada, contadorBoletos, cliente.Nombre);
                            }

                            GuardarTransaccion(boleto);

                            GenerarQR(boleto);

                            MessageBox.Show("Compra realizada:\n" + boleto.ObtenerInformacion());

                            contadorBoletos++;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No hay boletos disponibles en la zona {cliente.ZonaDeseada} para {cliente.Nombre}");
                    }
                }
            }
        }

        private void GuardarTransaccion(ClassBoleto boleto)
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine($"{boleto.Numero};{boleto.NombreComprador};{boleto.Zona};{boleto.Asiento};{boleto.FechaHoraCompra}");
            }
        }

        private void GenerarQR(ClassBoleto boleto)
        {
            string rutaQR = $"QR_{boleto.Numero}.txt";
            File.WriteAllText(rutaQR, $"Boleto #{boleto.Numero}\nZona: {boleto.Zona}\nAsiento: {boleto.Asiento}\nCliente: {boleto.NombreComprador}");
        }
    }
}


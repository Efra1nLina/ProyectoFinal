using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class DevolverBoleto : Form
    {
        ClassCompras cancelar;
        ClassOrden orden;
        ClassEstadio estadio;

        string? nombreC, zonaE;
        int numTicket;

        public DevolverBoleto(ClassOrden ordenRef, ClassEstadio estadioRef)
        {
            InitializeComponent();
            cancelar = new ClassCompras();
            orden = ordenRef;
            estadio = estadioRef;
        }


        private void botonCancelar_Click(object sender, EventArgs e)
        {
            nombreC = nombreCliente.Text;
            zonaE = zonaEl.SelectedItem?.ToString();
            // Leer los asientos ingresados separados por comas
            string entrada = numTickets.Text;
            string[] partes = entrada.Split(',');

            List<int> asientosAEliminar = new List<int>();

            foreach (string parte in partes)
            {
                if (int.TryParse(parte.Trim(), out int numeroAsiento))
                {
                    if (numeroAsiento < 1 || numeroAsiento > SistemaGlobal.listaAsientosOcupados.Count)
                    {
                        MessageBox.Show($"El número de asiento {numeroAsiento} no existe");
                        return;
                    }

                    if (!SistemaGlobal.listaAsientosOcupados[numeroAsiento - 1])
                    {
                        MessageBox.Show($"El asiento {numeroAsiento} ya está libre.");
                        return;
                    }

                    asientosAEliminar.Add(numeroAsiento - 1); // Resta 1 porque la lista es base 0
                }
                else
                {
                    MessageBox.Show($"'{parte}' no es un número válido.");
                    return;
                }
            }

            // Cancelar los asientos
            foreach (int index in asientosAEliminar)
            {
                SistemaGlobal.listaAsientosOcupados[index] = false;
            }

            // Actualizar contador de ocupados :D
            SistemaGlobal.Ocupados();

            // Reintegrar los boletos cancelados
            int cantidadCancelada = asientosAEliminar.Count;
            SistemaGlobal.Compras.Push(zonaE, cantidadCancelada, nombreC);
            SistemaGlobal.Estadio.ReintegrarTickets(zonaE, cantidadCancelada);
            SistemaGlobal.Compras.ReasignarDesdePila(SistemaGlobal.Orden, SistemaGlobal.Estadio);

            MessageBox.Show($"{cantidadCancelada} boleto(s) cancelado(s) exitosamente.");
            MessageBox.Show($"Asientos ocupados ahora: {SistemaGlobal.contadorOcupados}");

            MessageBox.Show(SistemaGlobal.Compras.Mostrar(), "Elementos en la Pila de Cancelaciones");
            MessageBox.Show(SistemaGlobal.Estadio.Mostrar(), "Zonas del Estadio");
        }  

        private void zonaEl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DevolverBoleto_Load(object sender, EventArgs e)
        {

        }
    }
}

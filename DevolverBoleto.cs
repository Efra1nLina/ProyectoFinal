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
            zonaE = zonaEl.SelectedItem.ToString();

            if (!int.TryParse(numTickets.Text, out numTicket))
            {
                MessageBox.Show("Número de tickets inválido");
                return;
            }

            // Usar la pila global
            SistemaGlobal.Compras.Push(zonaE, numTicket, nombreC);

            // Reintegrar los tickets al estadio global
            SistemaGlobal.Estadio.ReintegrarTickets(zonaE, numTicket);

            // Reasignar desde pila a las personas en la cola
            SistemaGlobal.Compras.ReasignarDesdePila(SistemaGlobal.Orden, SistemaGlobal.Estadio);

            MessageBox.Show("Boleto cancelado exitosamente");

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

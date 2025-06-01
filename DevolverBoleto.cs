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

            // Agregar a la pila de cancelaciones
            cancelar.Push(zonaE, numTicket, nombreC);

            // Reintegrar los tickets al estadio
            estadio.ReintegrarTickets(zonaE, numTicket);

            // Intentar reasignar a personas en la cola
            cancelar.ReasignarDesdePila(orden, estadio);

            MessageBox.Show("Boleto cancelado exitosamente");
            
            MessageBox.Show(string.Join(" , ", cancelar.Mostrar()), "Elementos de la Lista", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            estadio.Mostrar();
            MessageBox.Show(estadio.Mostrar(), "oaaaaaaaaaaaaaaa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            MessageBox.Show(orden.MostrarCola(), "nose", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void zonaEl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DevolverBoleto_Load(object sender, EventArgs e)
        {

        }
    }
}

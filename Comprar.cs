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
    public partial class Comprar : Form
    {
        string nombre, zona; 
        int numAsiento;
        public List<ClassBoleto> boletosVendidos;
        public Comprar()
        {
            InitializeComponent();
            boletosVendidos = new List<ClassBoleto>();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Comprar_Load(object sender, EventArgs e)
        {

        }

        private void aceptarComprar_Click(object sender, EventArgs e)
        {
            nombre = nombreCliente.Text;
            zona= zonaElejida.SelectedItem.ToString();
            int.TryParse(asiento.Text, out numAsiento);
            MessageBox.Show(zona);
        }
    }
}
    
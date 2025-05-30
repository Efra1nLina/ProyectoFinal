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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonDisponibilidad_Click(object sender, EventArgs e)
        {
            Disponibilidad ventana = new Disponibilidad();
            ventana.Show(); 
        }
    }
}

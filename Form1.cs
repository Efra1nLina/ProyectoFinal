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

        private void botonComprar_Click(object sender, EventArgs e)
        {
            Disponibilidad ventana = new Disponibilidad(); 

            Comprar ventana2 = new Comprar(ventana); 


            // Por ejemplo: ventana principal a la izquierda
            ventana.Location = new Point(100, 100); // X = 100, Y = 100
                                                    // Y la otra a la derecha (ajusta el valor 800 si la ventana es más ancha)
            ventana2.Location = new Point(ventana.Location.X + ventana.Width + 10, ventana.Location.Y);

            // Mostrar ambas
            ventana.Show();
            ventana2.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            SistemaGlobal.Estadio.AgregarZona("VIP", 9, 0);
            SistemaGlobal.Estadio.AgregarZona("General", 42, 0);
            SistemaGlobal.Estadio.AgregarZona("Tribuna", 21, 0);
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            ClassOrden ordenGlobal = new ClassOrden();
            ClassEstadio estadioGlobal = new ClassEstadio();

            DevolverBoleto ventana = new DevolverBoleto(ordenGlobal, estadioGlobal);
            ventana.Show();

        }
    }
}

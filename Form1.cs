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
            LimpiarArchivosInicio();
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

        private void LimpiarArchivosInicio()
        {
            string carpeta = @"C:\estadio";
            string rutaArchivo = Path.Combine(carpeta, "transacciones.txt");

            try
            {
                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                    return;
                }

                // Borrar archivo de transacciones
                if (File.Exists(rutaArchivo))
                {
                    File.Delete(rutaArchivo);
                }

                // Borrar imágenes QR
                foreach (var archivo in Directory.GetFiles(carpeta, "QR_*.png"))
                {
                    File.Delete(archivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar archivos: {ex.Message}");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Disponibilidad ventana = new Disponibilidad();
            ventana.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ClassOrden ordenGlobal = new ClassOrden();
            ClassEstadio estadioGlobal = new ClassEstadio();

            DevolverBoleto ventana = new DevolverBoleto(ordenGlobal, estadioGlobal);
            ventana.Show();
        }
    }
}

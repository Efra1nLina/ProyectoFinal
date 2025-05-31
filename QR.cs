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
    public partial class QR : Form
    {
        public QR(string rutaImagenQR)
        {
            InitializeComponent();

        }

        private void QR_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            if (File.Exists(rutaImagenQR))
            {
                pictureBox1.Image = Image.FromFile(rutaImagenQR);
            }
            else
            {
                MessageBox.Show("No se encontró la imagen del código QR.");
            }
        }
    }
}

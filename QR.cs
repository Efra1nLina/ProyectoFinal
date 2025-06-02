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
        string rutaImagenQR { get; set; }
        ClassBoleto boleto;
        public QR(ClassBoleto boleto, string ruta)
        {
            InitializeComponent();
            rutaImagenQR = ruta;
            this.boleto = boleto;


        }

        private void QR_Load(object sender, EventArgs e)
        {


            if (File.Exists(rutaImagenQR))
            {
                pictureBox1.Image = Image.FromFile(rutaImagenQR);
            }
            else
            {
                MessageBox.Show("No se encontró la imagen del código QR.");
            }
            imprimirNombre.Text = "Nombre: " + boleto.NombreComprador;
            imprimirZona.Text = "Zona: " + boleto.Zona;
            imprimirAsiento.Text = "Asiento: " + boleto.Asiento.ToString();
            imprimirNumero.Text = "N° Boleto: " + boleto.Numero.ToString();
            imprimirFecha.Text = boleto.FechaHoraCompra.ToString();
            //para tipo vip
            if (boleto is ClassBoletoVIP vip)
            {
                // Asegúrate de tener un label en el form para esto
                labelBeneficios.Text = "Beneficios: " + vip.Beneficios;
                labelBeneficios.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void imprimirNumero_Click(object sender, EventArgs e)
        {

        }
    }
}

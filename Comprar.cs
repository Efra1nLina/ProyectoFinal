using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ProyectoFinal
{
    public partial class Comprar : Form
    {
        string? nombre, zona; 
        int numAsiento;
        
        public Comprar()
        {
            InitializeComponent();
            

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
            zona = zonaElejida.SelectedItem.ToString();

            int cantidadBoletos = 1;
            int.TryParse(cantBoletos.Text, out cantidadBoletos);

            List<int> listaAsientos = new List<int>();
            string[] asientosTexto = asiento.Text.Split(',');

            foreach (string num in asientosTexto)
            {
                if (int.TryParse(num.Trim(), out int asientoNum))
                {
                    listaAsientos.Add(asientoNum);
                }
            }

            if (listaAsientos.Count != cantidadBoletos)
            {
                MessageBox.Show("La cantidad de asientos no coincide con la cantidad de boletos.");
                return;
            }

            
            ClassEstadio estadio = SistemaGlobal.Estadio;
            ClassOrden orden = SistemaGlobal.Orden;
            ClassTransaccion transaccion = SistemaGlobal.Transaccion;

            // Inserta en la orden
            for (int i = 0; i < cantidadBoletos; i++)
            {
                orden.Insertar(nombre, zona);
            }

            // Procesar la transacción
            List<ClassBoleto> boletosGenerados = transaccion.ProcesarColaConAsientos(orden, estadio, listaAsientos);

            foreach (var boleto in boletosGenerados)
            {
                string rutaQR = $@"C:\estadio\QR_{boleto.Numero}.png";
                QR vistaQR = new QR(boleto, rutaQR);
                vistaQR.Show();
            }

        }
    }
}
    
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

            // Leer cantidad de boletos
            int cantidadBoletos = 1;
            int.TryParse(cantBoletos.Text, out cantidadBoletos);

            // Leer y procesar asientos
            List<int> listaAsientos = new List<int>();
            string[] asientosTexto = asiento.Text.Split(',');

            foreach (string num in asientosTexto)
            {
                if (int.TryParse(num.Trim(), out int asientoNum))
                {
                    listaAsientos.Add(asientoNum);
                }
            }

            // Validar que haya la misma cantidad de asientos que de boletos
            if (listaAsientos.Count != cantidadBoletos)
            {
                MessageBox.Show("La cantidad de asientos no coincide con la cantidad de boletos.");
                return;
            }

            // Crear estadio
            ClassEstadio estadio = new ClassEstadio();
            estadio.AgregarZona("VIP", 100, 0);
            estadio.AgregarZona("General", 200, 0);

            // Crear la orden y pasar cada asiento
            ClassOrden orden = new ClassOrden();
            for (int i = 0; i < cantidadBoletos; i++)
            {
                
                orden.Insertar(nombre, zona); // Aquí no pasamos asiento directamente
            }

            // Procesar la transacción con lista de asientos
            ClassTransaccion transaccion = new ClassTransaccion();
            transaccion.ProcesarColaConAsientos(orden, estadio, listaAsientos); // este método lo agregaremos ahora

            for (int i = 1; i <= cantidadBoletos; i++)
            {
                string rutaQR = $@"C:\estadio\QR_{i}.png";
                QR vistaQR = new QR(rutaQR);
                vistaQR.Show(); // uno por cada boleto
            }
        }
    }
}
    
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
        Disponibilidad disponibilidad;
        public Comprar(Disponibilidad disponibilidadForm)
        {
            InitializeComponent();
            this.disponibilidad = disponibilidadForm;

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
            // Validar seleccion de zona
            if (string.IsNullOrEmpty(zona))
            {
                MessageBox.Show("Por favor seleccione una zona válida.");
                return;
            }

            // Obtener cantidad de boletos
            if (!int.TryParse(cantBoletos.Text, out int cantidadBoletos) || cantidadBoletos < 1)
            {
                MessageBox.Show("Ingrese una cantidad válida de boletos.");
                return;
            }

            // Procesar asientos ingresados
            List<int> listaAsientos = new List<int>();
            string[] asientosTexto = asiento.Text.Split(',');

            foreach (string num in asientosTexto)
            {
                if (int.TryParse(num.Trim(), out int asientoNum))
                {
                    // Validar rango general (1-72)
                    if (asientoNum < 1 || asientoNum > 72)
                    {
                        MessageBox.Show($"El asiento {asientoNum} no existe. Debe ser entre 1 y 72.");
                        return;
                    }
                    listaAsientos.Add(asientoNum);
                }
                else
                {
                    MessageBox.Show($"'{num}' no es un número de asiento válido.");
                    return;
                }
            }

            // Validar cantidad de asientos vs boletos
            if (listaAsientos.Count != cantidadBoletos)
            {
                MessageBox.Show("La cantidad de asientos no coincide con la cantidad de boletos.");
                return;
            }

            // Validar que los asientos correspondan a la zona seleccionada
            foreach (int asientoNum in listaAsientos)
            {
                if (!AsientoPerteneceAZona(asientoNum, zona))
                {
                    string rangoEsperado = ObtenerRangoZona(zona);
                    MessageBox.Show($"El asiento {asientoNum} no pertenece a la zona {zona}. {rangoEsperado}");
                    return;
                }

                // Validar si el asiento ya está ocupado
                if (SistemaGlobal.listaAsientosOcupados[asientoNum - 1])
                {
                    MessageBox.Show($"El asiento {asientoNum} ya está ocupado.");
                    return;
                }
            }

            // Procesar la compra
            ClassEstadio estadio = SistemaGlobal.Estadio;
            ClassOrden orden = SistemaGlobal.Orden;
            ClassTransaccion transaccion = SistemaGlobal.Transaccion;

            // Insertar en la orden
            for (int i = 0; i < cantidadBoletos; i++)
            {
                orden.Insertar(nombre, zona);
                SistemaGlobal.listaAsientosOcupados[listaAsientos[i] - 1] = true;
            }
            SistemaGlobal.Ocupados();

            // Procesar la transacción
            List<ClassBoleto> boletosGenerados = transaccion.ProcesarColaConAsientos(orden, estadio, listaAsientos);
            //Para mostrar la ventana disponibilidad
            if (disponibilidad == null)
            {
                disponibilidad = new Disponibilidad();
            }
            disponibilidad.Show();
            disponibilidad.BringToFront();
            disponibilidad.ActualizarDisponibilidad();

            foreach (var boleto in boletosGenerados)
            {
                string rutaQR = $@"C:\estadio\QR_{boleto.Numero}.png";
                QR vistaQR = new QR(boleto, rutaQR);
                vistaQR.Show();
            }
        }

        // para validar zonas
        private bool AsientoPerteneceAZona(int asientoNum, string zona)
        {
            switch (zona.ToUpper())
            {
                case "VIP":
                    return asientoNum >= 1 && asientoNum <= 9;
                case "TRIBUNA":
                    return asientoNum >= 10 && asientoNum <= 30;
                case "GENERAL":
                    return asientoNum >= 31 && asientoNum <= 72;
                default:
                    return false;
            }
        }

        private string ObtenerRangoZona(string zona)
        {
            switch (zona.ToUpper())
            {
                case "VIP":
                    return "Los asientos VIP deben estar entre 1 y 9.";
                case "TRIBUNA":
                    return "Los asientos de Tribuna deben estar entre 10 y 30.";
                case "GENERAL":
                    return "Los asientos Generales deben estar entre 31 y 72.";
                default:
                    return "Zona no reconocida.";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            nombre = nombreCliente.Text;
            zona = zonaElejida.SelectedItem.ToString();
            // Validar seleccion de zona
            if (string.IsNullOrEmpty(zona))
            {
                MessageBox.Show("Por favor seleccione una zona válida.");
                return;
            }

            // Obtener cantidad de boletos
            if (!int.TryParse(cantBoletos.Text, out int cantidadBoletos) || cantidadBoletos < 1)
            {
                MessageBox.Show("Ingrese una cantidad válida de boletos.");
                return;
            }

            // Procesar asientos ingresados
            List<int> listaAsientos = new List<int>();
            string[] asientosTexto = asiento.Text.Split(',');

            foreach (string num in asientosTexto)
            {
                if (int.TryParse(num.Trim(), out int asientoNum))
                {
                    // Validar rango general (1-72)
                    if (asientoNum < 1 || asientoNum > 72)
                    {
                        MessageBox.Show($"El asiento {asientoNum} no existe. Debe ser entre 1 y 72.");
                        return;
                    }
                    listaAsientos.Add(asientoNum);
                }
                else
                {
                    MessageBox.Show($"'{num}' no es un número de asiento válido.");
                    return;
                }
            }

            // Validar cantidad de asientos vs boletos
            if (listaAsientos.Count != cantidadBoletos)
            {
                MessageBox.Show("La cantidad de asientos no coincide con la cantidad de boletos.");
                return;
            }

            // Validar que los asientos correspondan a la zona seleccionada
            foreach (int asientoNum in listaAsientos)
            {
                if (!AsientoPerteneceAZona(asientoNum, zona))
                {
                    string rangoEsperado = ObtenerRangoZona(zona);
                    MessageBox.Show($"El asiento {asientoNum} no pertenece a la zona {zona}. {rangoEsperado}");
                    return;
                }

                // Validar si el asiento ya esta ocupado
                if (SistemaGlobal.listaAsientosOcupados[asientoNum - 1])
                {
                    MessageBox.Show($"El asiento {asientoNum} ya está ocupado.");
                    return;
                }
            }

            // Procesar la compra
            ClassEstadio estadio = SistemaGlobal.Estadio;
            ClassOrden orden = SistemaGlobal.Orden;
            ClassTransaccion transaccion = SistemaGlobal.Transaccion;

            // Insertar en la orden
            for (int i = 0; i < cantidadBoletos; i++)
            {
                orden.Insertar(nombre, zona);
                SistemaGlobal.listaAsientosOcupados[listaAsientos[i] - 1] = true;
            }
            SistemaGlobal.Ocupados();

            // Procesar la transacción
            List<ClassBoleto> boletosGenerados = transaccion.ProcesarColaConAsientos(orden, estadio, listaAsientos);
            //Para mostrar la ventana disponibilidad
            if (disponibilidad == null)
            {
                disponibilidad = new Disponibilidad();
            }
            disponibilidad.Show();
            disponibilidad.BringToFront();
            disponibilidad.ActualizarDisponibilidad();

            foreach (var boleto in boletosGenerados)
            {
                string rutaQR = $@"C:\estadio\QR_{boleto.Numero}.png";
                QR vistaQR = new QR(boleto, rutaQR);
                vistaQR.Show();
            }
        }
    }
}
    
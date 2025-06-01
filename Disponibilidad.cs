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
    public partial class Disponibilidad : Form
    {
        public Disponibilidad()
        {
            InitializeComponent();
            this.Paint += Disponibilidad_Paint;
        }
        private int DibujarZona(Graphics g, string nombreZona, int filas, int filaBase, Point inicio, ref int contador)
        {
            int ancho = 40;
            int alto = 40;
            int paddingX = 8;
            int paddingY = 10;
            Font fuente = this.Font;
            SizeF tamañoTexto = g.MeasureString(nombreZona, new Font(fuente.FontFamily, 10, FontStyle.Bold));
            float textoX = (this.ClientSize.Width - tamañoTexto.Width) / 2;
            g.DrawString(nombreZona, new Font(fuente.FontFamily, 10, FontStyle.Bold), Brushes.Black, textoX, inicio.Y - 25);
            ocupado.Text = SistemaGlobal.contadorOcupados.ToString();
            libre.Text = (72 - SistemaGlobal.contadorOcupados).ToString();

            for (int fila = 0; fila < filas; fila++)
            {
                int filaGlobal = filaBase + fila;
                int asientosEnFila = 4 + filaGlobal;

                int filaY = inicio.Y + fila * (alto + paddingY);

                int filaAnchoTotal = asientosEnFila * (ancho + paddingX);
                int inicioX = (this.ClientSize.Width - filaAnchoTotal) / 2;

                for (int i = 0; i < asientosEnFila; i++)
                {
                    int x = inicioX + i * (ancho + paddingX);
                    int y = filaY;

                    Rectangle rect = new Rectangle(x, y, ancho, alto);
                    //Para cambiar el color de los asientos ocupados verificando en la lista :D
                    int numeroAsiento = contador - 1;
                    // Color según ocupación
                    Brush fondoColor = (numeroAsiento >= 0 && numeroAsiento < SistemaGlobal.listaAsientosOcupados.Count && SistemaGlobal.listaAsientosOcupados[numeroAsiento])
                        ? Brushes.Red
                        : Brushes.Green;
                    g.FillRectangle(fondoColor, rect);
                    g.DrawRectangle(Pens.Black, rect);

                    string texto = contador.ToString();
                    SizeF textoSize = g.MeasureString(texto, fuente);
                    float tx = x + (ancho - textoSize.Width) / 2;
                    float ty = y + (alto - textoSize.Height) / 2;

                    g.DrawString(texto, fuente, Brushes.Black, tx, ty);
                    contador++;
                }
            }

            return contador;
        }
        private void Disponibilidad_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int filaBase = 0;
            int contador = 1;

            contador = DibujarZona(g, "VIP", 2, filaBase, new Point(0, 40), ref contador);
            filaBase += 2;

            contador = DibujarZona(g, "Tribuna", 3, filaBase, new Point(0, 160), ref contador);
            filaBase += 3;

            contador = DibujarZona(g, "General", 4, filaBase, new Point(0, 340), ref contador);

        }

        private void Disponibilidad_Load(object sender, EventArgs e)
        {

        }
        public void ActualizarDisponibilidad()
        {
            this.Invalidate(); // Fuerza la actualización de la interfaz
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

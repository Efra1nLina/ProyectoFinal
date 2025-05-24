using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class ClassEstadio
    {
        public int TotalNodos { get; set; }
        public ClassNodo? Inicio { get; set; }

        public ClassEstadio()
        {
            Inicio = null;
            TotalNodos = 0;
        }

        public void AgregarInicio(string zona, int capacidad, int tickets)
        {
            ClassNodo nuevo = new ClassNodo(zona, capacidad, tickets);
            nuevo.Siguiente = Inicio;
            Inicio = nuevo;
            TotalNodos++;
        }

        public string Mostrar()
        {
            StringBuilder lista = new StringBuilder();
            if (Inicio != null)
            {
                ClassNodo auxiliar = Inicio;

                while (auxiliar != null)
                {
                    lista.AppendLine($"Zona: {auxiliar.Zona}, Capacidad: {auxiliar.Capacidad}, Tickets disponibles: {auxiliar.Tickets}");
                    auxiliar = auxiliar.Siguiente;
                }

                return lista.ToString();
            }
            else
            {
                lista.Append("No existen datos");
                return lista.ToString();
            }
        }

        public int MostrarNodos()
        {
            return TotalNodos;
        }
    }
}

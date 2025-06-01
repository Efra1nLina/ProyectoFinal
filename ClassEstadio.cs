using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ClassEstadio
    {  
        public ClassNodoEstadio? Inicio { get; set; }
        public int TotalNodos { get; set; }

        public ClassEstadio()
        {
            Inicio = null;
            TotalNodos = 0;
        }

        // Agrega una nueva zona al inicio de la lista
        public void AgregarZona(string zona, int capacidad, int tickets)
        {
            ClassNodoEstadio nuevo = new ClassNodoEstadio(zona, capacidad, tickets);
            nuevo.Siguiente = Inicio;
            Inicio = nuevo;
            TotalNodos++;
        }

        public string Mostrar()
        {
            if (Inicio == null)
                return "No existen zonas registradas.";

            StringBuilder sb = new StringBuilder();
            ClassNodoEstadio? actual = Inicio;

            while (actual != null)
            {
                sb.AppendLine($"Zona: {actual.Zona}, Capacidad: {actual.Capacidad}, Lugares reservados: {actual.Tickets}");
                actual = actual.Siguiente;
            }

            return sb.ToString();
        }

        public bool VerificarDisponibilidad(string zona, int cantidadSolicitada)
        {
            ClassNodoEstadio? actual = Inicio;
            while (actual != null)
            {
                if (actual.Zona == zona)
                {
                    //return actual.Tickets >= cantidadSolicitada;
                    return actual.Capacidad - actual.Tickets >= cantidadSolicitada;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        public bool AsignarTickets(string zona, int cantidad)
        {
            ClassNodoEstadio? actual = Inicio;
            while (actual != null)
            {
                if (actual.Zona == zona)
                {
                    if ((actual.Capacidad - actual.Tickets) >= cantidad)
                    {
                        actual.Tickets += cantidad;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        public void ReintegrarTickets(string zona, int cantidad)
        {
            ClassNodoEstadio? actual = Inicio;
            while (actual != null)
            {
                if (actual.Zona == zona)
                {
                    actual.Tickets -= cantidad;
                    return;
                }
                actual = actual.Siguiente;
            }
        }

        public int MostrarNodos()
        {
            return TotalNodos;
        }
    }
}

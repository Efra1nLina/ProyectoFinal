using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Orden
    {
        
        private Usuario? frente;
        private Usuario? final;

        public Orden()
        {
            frente = null;
            final = null;
        }

        public bool EstaVacia()
        {
            return frente == null;
        }

        public void Encolar(string nombre, string zona)
        {
            Usuario nuevo = new Usuario(nombre, zona);

            if (EstaVacia())
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final!.Siguiente = nuevo;
                final = nuevo;
            }
        }

        public Usuario? Desencolar()
        {
            if (EstaVacia()) return null;

            Usuario eliminado = frente!;
            frente = frente!.Siguiente;

            if (frente == null) final = null;

            return eliminado;
        }

        public string MostrarCola()
        {
            if (EstaVacia()) return "Cola vacía.";

            StringBuilder lista = new StringBuilder();
            Usuario? aux = frente;

            while (aux != null)
            {
                lista.AppendLine($"Cliente: {aux.Nombre} - Zona solicitada: {aux.ZonaDeseada}");
                aux = aux.Siguiente;
            }

            return lista.ToString();
        }
    }
}

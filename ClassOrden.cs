using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ClassOrden
    {
        
        private ClassNodoOrden? frente;
        private ClassNodoOrden? final;

        public ClassOrden()
        {
            frente = null;
            final = null;
        }

        public bool EstaVacia()
        {
            return frente == null; //clase para verificar si esta vacia en otras clases
        }

        public void Insertar(string nombre, string zona)
        {
            ClassNodoOrden nuevo = new ClassNodoOrden(nombre, zona);

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

        public ClassNodoOrden? Desencolar()
        {
            if (EstaVacia())
            {
                MessageBox.Show("No existen clientes");
                return null;
            }

            ClassNodoOrden eliminado = frente!; //el ! le indica al compilador que frente no es null en este punto (porque ya se verifica antes)
            frente = frente!.Siguiente; //si no habia más nodos, frente sera null

            if (frente == null)
            {
                final = null;
            }

            return eliminado;
        }

        public string MostrarCola()
        {
            if (EstaVacia()) return "Cola vacía.";

            StringBuilder lista = new StringBuilder();
            ClassNodoOrden? aux = frente;

            while (aux != null)
            {
                lista.AppendLine($"Cliente: {aux.Nombre} - Zona solicitada: {aux.ZonaDeseada}");
                aux = aux.Siguiente;
            }

            return lista.ToString();
        }
        public int Contar()
        {
            int contador = 0;
            ClassNodoOrden? actual = frente;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }
    }
}

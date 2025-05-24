using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Usuario
    {
        public string Nombre { get; set; }
        public string ZonaDeseada { get; set; }
        public Usuario? Siguiente { get; set; }

        public Usuario(string nombre, string zona)
        {
            Nombre = nombre;
            ZonaDeseada = zona;
            Siguiente = null;
        }
    }
}

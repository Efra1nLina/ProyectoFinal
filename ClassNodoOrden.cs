using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class ClassNodoOrden
    {
        public string Nombre { get; set; }
        public string ZonaDeseada { get; set; }
        public ClassNodoOrden? Siguiente { get; set; }

        public ClassNodoOrden(string nombre, string zona)
        {
            Nombre = nombre;
            ZonaDeseada = zona;
            Siguiente = null;
        }
    }
}

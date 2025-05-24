using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class ClassNodoCompras
    {
        public string Zona { get; set; }
        public int TicketsDevueltos { get; set; }
        public string? Cliente { get; set; }
        public ClassNodoCompras? Siguiente { get; set; }

        public ClassNodoCompras(string zona, int tickets, string cliente)
        {
            Zona = zona;
            TicketsDevueltos = tickets;
            Cliente = cliente;
            Siguiente = null;
        }
    }
}

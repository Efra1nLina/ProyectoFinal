﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ClassNodoEstadio
    {
        public string Zona { get; set; }
        public int Capacidad { get; set; }
        public int Tickets { get; set; }
        public ClassNodoEstadio? Siguiente { get; set; } //mueve el puntero a la otra lista

        public ClassNodoEstadio(string zona, int capacidad, int tickets)
        {
            Zona = zona;
            Capacidad = capacidad;
            Tickets = tickets;
            Siguiente = null;
        }
    }
}

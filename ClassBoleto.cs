using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ClassBoleto
    {

        public int Numero { get; set; }               
        public string Zona { get; set; }               
        public int Asiento { get; set; }               
        public string NombreComprador { get; set; }  
        public DateTime FechaHoraCompra { get; set; } 

        public ClassBoleto(int numero, string zona, int asiento, string nombreComprador)
        {
            Numero = numero;
            Zona = zona;
            Asiento = asiento;
            NombreComprador = nombreComprador;
            FechaHoraCompra = DateTime.Now;
        }

        public virtual string ObtenerInformacion()
        {
            return $"Boleto #{Numero} | Zona: {Zona} | Asiento: {Asiento} | Comprador: {NombreComprador} | Fecha: {FechaHoraCompra}";
        }
    }
} 
                                                                                                
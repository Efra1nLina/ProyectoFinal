using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class SistemaGlobal
    {
        public static ClassEstadio Estadio;
        public static ClassOrden Orden;
        public static ClassCompras Compras;
        public static ClassTransaccion Transaccion;
        public static List<bool> listaAsientosOcupados;
        public static int contadorOcupados; 
        // Constructor estático para inicializar las variables al cargar la clase
        static SistemaGlobal()
        {
            Estadio = new ClassEstadio();
            Orden = new ClassOrden();
            Compras = new ClassCompras();
            Transaccion = new ClassTransaccion();
            listaAsientosOcupados = new List<bool>(new bool[72]); // Inicializa los asientos ocupados en false
            contadorOcupados = 0;
        }

        public static void Ocupados()
        {
            contadorOcupados = 0;

            for (int i = 0; i < listaAsientosOcupados.Count; i++)
            {
                if (listaAsientosOcupados[i] == true)
                {
                    contadorOcupados++;
                }
            }
        }
    }

}
    
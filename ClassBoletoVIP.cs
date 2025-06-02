using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class ClassBoletoVIP : ClassBoleto
    {
        public string Beneficios { get; set; }

        public ClassBoletoVIP(int numero, string zona, int asiento, string nombreComprador)
            : base(numero, zona, asiento, nombreComprador)
        {
            Beneficios = "Entrada preferencial, bebidas incluidas, acceso a área exclusiva";
            // Debug
            MessageBox.Show($"Boleto VIP creado - Beneficios: {Beneficios}");
        }

        public override string ObtenerInformacion()
        {
            return base.ObtenerInformacion() + $" | Beneficios: {Beneficios}";
        }
    }
}

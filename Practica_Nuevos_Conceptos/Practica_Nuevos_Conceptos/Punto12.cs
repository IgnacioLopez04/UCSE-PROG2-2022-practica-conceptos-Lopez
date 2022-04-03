using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Nuevos_Conceptos
{
    public static class Punto12
    {
        public static decimal CelsiusFahrenheit(this decimal temperatura)
        {
            return (temperatura * (decimal)2.12);
        }

        public static decimal FahrenheitCelsius(this decimal temperatura)
        {
            return (temperatura / (decimal)2.12);
        }
    }
}

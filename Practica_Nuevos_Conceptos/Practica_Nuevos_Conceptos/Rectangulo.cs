using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Nuevos_Conceptos
{
    public static class Rectangulo
    {
        public static decimal Perimetro(this decimal piso, decimal altura) //El this no es necesario aca
        {
            return (piso * 2) + (altura * 2);
        }

        public static decimal Area(this decimal piso, decimal altura) //El this no es necesario aca
        {
            return piso * altura;
        }
    }
}

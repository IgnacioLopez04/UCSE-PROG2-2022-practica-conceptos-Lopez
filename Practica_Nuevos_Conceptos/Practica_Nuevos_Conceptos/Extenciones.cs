using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practica_Nuevos_Conceptos
{
    public static class _Extenciones //Las clases no van con _ y deberia ser Extensiones
    {
        public static int CantidadPalabras(this string stringUtilizar) //Punto 1
        {
            string[] str = stringUtilizar.Split(' ');
            return str.Count(); //podria ser una sola linea
        }

        public static int CantidadPalabras(this string stringUtilizar, char separador) //Punto 2
        {
            string[] str = stringUtilizar.Split(separador);
            return str.Count(); //podria ser una sola linea
        }

        public static decimal Resta(this DateTime fecha1, DateTime fecha2) //Punto 3
        {
            return (fecha1.Second - fecha2.Second) / 60;
        }

        public static double PromedioLista(this List<int> lista) //Punto 4
        {

            return lista.Sum() / lista.Count();

            // Simplemente se podria realizar un return lista.Average(); 
        }

        public static int ParesPorImpares(this List<int> lista) // Punto 5
        {
            int suma = 0;
            int resta = 0;

            foreach (int item in lista)
            {
                if (item % 2 == 0)
                {
                    suma += item;
                }
                else
                {
                    resta -= item;
                }
            }

            return suma * resta;
            //Se podria usar lambda. Ej
            //var sumaPares = lista.Where(x=>x %2 == 0).Sum();
        }

        public static DateTime DateTimeString(this string fecha) //Punto 6
        {
            try
            {
                return DateTime.Parse(fecha);
            }
            catch
            {
                return DateTime.MinValue;
            }

        }

        public static string StringInvertido(this string str) //Punto 7
        {
            string strInverso = " ";

            foreach (char letra in str)
            {
                strInverso += letra;
            }

            //revisar la funcion Reverse()
            return strInverso;
        }

        public static string UnionStrings(this string[] palabras, char separador) //Punto 8
        {
            string union = "";
            foreach (string str in palabras)
            {
                union += str;
            }
            //Revisar string.join
            return union;
        }

        public static bool CorreoElectronico(this string correo) //Punto 9
        {
            return Regex.IsMatch(correo, @"(@)(.+)$"); //la expresion regular no es correcta pero esta bien el uso de regex
        }

        public static bool EsCuit(this string cuit) // Punto 10
        {
            return Regex.IsMatch(cuit, @"\d{2}\-?\d{8}\-?\d{1}$");
        }
        public static Cliente Resta(this Cliente cliente1, Cliente cliente2) //Punto 11
        {
            if (cliente1.Cuit.EsCuit() == cliente2.Cuit.EsCuit())
            {
                cliente1.Saldo = cliente1.Saldo - cliente2.Saldo;
                return cliente1;
            }
            else
            {
                return cliente1.Saldo < cliente2.Saldo ? cliente1 : cliente2;
            }
        }

        public static int Resta(this int numero1, int numero2) //Punto 13
        {
            return numero1 - numero2;
        }
    }
}

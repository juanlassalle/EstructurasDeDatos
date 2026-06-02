using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ejercicio
{
    internal class Program
    {
        //Se requiere obtener la suma de las cantidades contenidas en un arreglo de
        //10 elementos.
        static void Main(string[] args)
        {
            int[] arreglo = { 2, 5, 6, 7, 11, 2, 3, 4, 5, 6 };
            int suma = 0;

            for (int i = 0; i <= arreglo.Length - 1; i++)
            {
                suma = suma + arreglo[i];
            }

            Console.Write($"El vector: [{string.Join(" , ", arreglo)}]");
            Console.WriteLine("\n");
            Console.Write($"La suma de los arreglos es: {suma}");
            Console.WriteLine("\n");
        }
    }
}

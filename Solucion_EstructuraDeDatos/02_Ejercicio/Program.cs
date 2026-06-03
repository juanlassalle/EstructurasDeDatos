using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ejercicio
{
    internal class Program
    {
        //Se requiere un algoritmo para obtener un vector (C) de N elementos que
        //contenga la suma de los elementos correspondientes de otros dos vectores
        //(A y B).
        static void Main(string[] args)
        {
            int nElementos;
            Console.Write("Ingresar la cantidad de elementos de los vectores: ");
            nElementos = int.Parse(Console.ReadLine());

            int[] vectorA = new int[nElementos];
            int[] vectorB = new int[nElementos];
            int[] vectorC = new int[nElementos];

            int i = 0;

            while (i < nElementos)
            {
                Console.WriteLine($"\n=== Elemento {i} ===");

                Console.Write("Ingresar valor para Vector A: ");
                vectorA[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar valor para Vector B: ");
                vectorB[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                i++;
            }

            i = default;

            while (i < nElementos)
            {
                vectorC[i] = vectorA[i] + vectorB[i];
                i++;
            }

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Vector C (Suma): [{string.Join(", ", vectorC)}]");
            Console.WriteLine("-------------------------------------------");

        }
    }
}

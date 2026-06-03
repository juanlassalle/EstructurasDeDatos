using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Ejercicio
{
    internal class Program
    {
        //Realice un algoritmo que lea un vector de seis elementos e intercambie las
        //posiciones de sus elementos, de tal forma que el primer elemento pase a
        //ser el último y el último el primero, el segundo el penúltimo y así sucesivamente,
        //e imprima ese vector.
        static void Main(string[] args)
        {
            int[] miVector = new int[6];

            LlenarVector(miVector);

            Console.WriteLine("\n--- Vector Original ---");
            ImprimirVector(miVector);

            InvertirVector(miVector);

            Console.WriteLine("\n--- Vector Invertido ---");
            ImprimirVector(miVector);

            Console.ReadLine();
        }
        private static void LlenarVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Ingresar el elemento {i + 1} de {vector.Length}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void InvertirVector(int[] vector)
        {
            for (int i = 0; i < vector.Length / 2; i++)
            {
                // Guardamos el valor de la izquierda en una variable temporal
                int aux = vector[i];

                // Calculamos la posición espejo de la derecha
                int posicionEspejo = vector.Length - 1 - i;

                // Intercambiamos los valores
                vector[i] = vector[posicionEspejo];
                vector[posicionEspejo] = aux;
            }
        }
        private static void ImprimirVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"[{vector[i]}] ");
            }
            Console.WriteLine();
        }
    }
}

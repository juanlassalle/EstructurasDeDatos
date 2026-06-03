using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Ejercicio
{
    internal class Program
    {
        //Se requiere determinar cuántos ceros se encuentran en un arreglo de cuatro
        //renglones y cuatro columnas, las cuales almacenan valores comprendidos
        //entre 0 y 9.
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            int contar = 0;

            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine($"Ingresar elemento en la coordenada [{f},{c}]: ");
                    matriz[f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (matriz[f,c] == 0)
                    {
                        contar++;
                    }
                }
            }

            Console.WriteLine($"La cantidad de ceros que tiene la matriz es {contar}");
        }
    }
}

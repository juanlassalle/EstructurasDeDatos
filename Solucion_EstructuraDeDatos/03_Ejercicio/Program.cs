using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ejercicio
{
    internal class Program
    {
        //Se tienen los nombres de los N alumnos de una escuela, además de su
        //promedio general. Realice un algoritmo para capturar esta información, la
        //cual se debe almacenar en arreglos, un vector para el nombre y otro para
        //el promedio, después de capturar la información se debe ordenar con base
        //en su promedio, de mayor a menor, los nombres deben corresponder con
        //los promedios.
        static void Main(string[] args)
        {
            int nAlumnos;
            string[] vectorNombres;
            double[] vectorPromedio;
           

            Console.Write("Ingresar cantidad de alumnos: ");
            nAlumnos = int.Parse(Console.ReadLine());

            vectorNombres = new string[nAlumnos];
            vectorPromedio = new double[nAlumnos];

            for (int i = 0; i < nAlumnos ; i++)
            {
                Console.WriteLine($"=====Alumno {i + 1}=====");
                Console.Write("Ingresar nombre: ");
                vectorNombres[i] = Console.ReadLine();
                Console.Write("Ingresar promedio: ");
                vectorPromedio[i] = double.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            for (int i = 0; i < nAlumnos; i++)
            {
                Console.WriteLine($"Nombres: {vectorNombres[i]} - Promedio: {vectorPromedio[i]}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("====Bubble Sort===");
            for (int i = 0; i < nAlumnos - 1; i++)
            {
                for (int j = 0; j < nAlumnos - i - 1; j++)
                {
                    if (vectorPromedio[j] < vectorPromedio[j + 1])
                    {
                        double auxiliar = vectorPromedio[j];
                        vectorPromedio[j] = vectorPromedio[j + 1];
                        vectorPromedio[j + 1] = auxiliar;

                        string aux = vectorNombres[j];
                        vectorNombres[j] = vectorNombres[j + 1];
                        vectorNombres[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("==== LISTA DE ALUMNOS ORDENADA (MAYOR A MENOR) ====");
            for (int i = 0; i < nAlumnos; i++)
            {
                Console.WriteLine($"Puesto {i + 1}: {vectorNombres[i]} - Promedio: {vectorPromedio[i]}");
            }

        }
    }
}

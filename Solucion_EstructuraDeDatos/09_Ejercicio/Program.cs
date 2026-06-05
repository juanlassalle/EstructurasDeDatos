using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Ejercicio
{
    internal class Program
    {
        //Realice el algoritmo para obtener la matriz transpuesta de cualquier matriz de orden M x N.
        static void Main(string[] args)
        {
            Ejecutar();
        }
        private static bool ValidadDimension(string _entrada,out int _dimension)
        {
            bool esValido = int.TryParse(_entrada, out _dimension) && _dimension > 0;

            if (!esValido) return false;

            return esValido;
        }
        private static int ObtenerFila()
        {
            string entrada;
            int fila;
            bool esFila;

            do
            {
                Console.Write("Ingresar fila: ");
                entrada = Console.ReadLine();
                esFila = ValidadDimension(entrada, out fila);
            }
            while (!esFila);
            return fila;
        }
        private static int ObtenerColumna()
        {
            string entrada;
            int columna;
            bool esColumna;

            do
            {
                Console.Write("Ingresar columna: ");
                entrada = Console.ReadLine();
                esColumna = ValidadDimension(entrada, out columna);
            }
            while (!esColumna);

            return columna;
        }

        private static T[,] GenerarMatriz<T>()
        {
            int fila = ObtenerFila();
            int columna = ObtenerColumna();

            T[,] matriz = new T[fila, columna];
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write($"Ingresar el elemento [{i},{j}]: ");
                    string entrada = Console.ReadLine();

                    matriz[i, j] = (T)Convert.ChangeType(entrada, typeof(T));
                }
            }
            return matriz;
        }
        private static T[,] TransponerMatriz<T>(T[,] matrizOriginal)
        {
            int filasOriginal = matrizOriginal.GetLength(0);
            int columnasOriginal = matrizOriginal.GetLength(1);

            T[,] matrizTranspuesta = new T[columnasOriginal, filasOriginal];

            for (int i = 0; i < filasOriginal; i++)
            {
                for (int j = 0; j < columnasOriginal; j++)
                {
                    matrizTranspuesta[j, i] = matrizOriginal[i, j];
                }
            }
            return matrizTranspuesta;
        }
        private static void Ejecutar()
        {
            Console.WriteLine("--- 1. CREANDO MATRIZ ORIGINAL ---");
            int[,] miMatriz = GenerarMatriz<int>();
            Console.WriteLine("\n");
            for (int i = 0; i < miMatriz.GetLength(0); i++)
            {
                for(int j = 0; j < miMatriz.GetLength(1); j++)
                {
                    Console.Write($" {miMatriz[i,j]} ");
                }
                Console.WriteLine();
            } 

            Console.WriteLine("\n--- 2. TRANSPONIENDO MATRIZ ---");
            int[,] miTranspuesta = TransponerMatriz(miMatriz);
            Console.WriteLine("\n");
            for (int i = 0; i < miTranspuesta.GetLength(0); i++)
            {
                for (int j = 0; j < miTranspuesta.GetLength(1); j++)
                {
                    Console.Write($" {miTranspuesta[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Matriz transpuesta generada con éxito de tamaño: {miTranspuesta.GetLength(0)}x{miTranspuesta.GetLength(1)}");
        }
    }
}

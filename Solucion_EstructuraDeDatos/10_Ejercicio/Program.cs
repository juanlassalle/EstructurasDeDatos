using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _10_Ejercicio
{
    internal class Program
    {
        //Realice el algoritmo para obtener el producto de dos matrices de orden M x N y P x Q.
        static void Main(string[] args)
        {
            Ejecutar();
        }
        private static bool ValidadDimension(string _entrada,out int _dimension)
        {
            bool esDimension = int.TryParse(_entrada, out _dimension) && _dimension > 0;
            if (!esDimension)
            {
                throw new ArgumentException("La dimensión ingresado no es valida. Debe ser un núemero mayor a cero");
            }

            return esDimension;
        }
        private static int ObtenerFila()
        {
            string entrada;
            int fila = 0;
            bool esFila = false;

            do
            {
                try
                {
                    Console.Write("Ingresar fila: ");
                    entrada = Console.ReadLine();

                    esFila = ValidadDimension(entrada, out fila);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine($"[Error]: {ex.Message}");
                    Console.WriteLine("Por favor, intente de nuevo.\n");
                }
                
            }
            while (!esFila);

            return fila;
        }
        private static int ObtenerColumna()
        {
            string entrada;
            int columna = 0;
            bool esColumna = false;

            do
            {
                try
                {
                    Console.Write("Ingresar columna: ");
                    entrada = Console.ReadLine();
                    esColumna = ValidadDimension(entrada, out columna);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine($"[Error]: {ex.Message}");
                    Console.WriteLine("Por favor, intente de nuevo.\n");
                }
            }
            while (!esColumna);

            return columna;
        }
        private static int[,] GenerarMatriz(int filas,int columnas, string nombreMatriz)
        {
            int[,] matriz = new int[filas, columnas];
            Console.WriteLine($"\n--- Llenando {nombreMatriz} ({filas}x{columnas}) ---");

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Ingresar elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return matriz;
        }
        private static int[,] MultiplicarMatrices(int[,] matrizA, int[,] matrizB)
        {
            int filasA = matrizA.GetLength(0);
            int columnasA = matrizA.GetLength(1); // Es igual a filasB
            int columnasB = matrizB.GetLength(1);

            int[,] resultado = new int[filasA, columnasB];

            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasB; j++)
                {
                    resultado[i, j] = 0;
                    for (int k = 0; k < columnasA; k++)
                    {
                        resultado[i, j] += matrizA[i, k] * matrizB[k, j];
                    }
                }
            }
            return resultado;
        }
        private static void MostrarMatriz(int[,] matriz, string nombre)
        {
            Console.WriteLine($"\n--- {nombre} ---");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                    Console.Write(matriz[i, j] + "\t");
                Console.WriteLine();
            }
        }
        private static void Ejecutar()
        {
            Console.WriteLine("=== Dimensiones de la Matriz A ===");
            int filasA = ObtenerFila();
            int columnasA = ObtenerColumna();

            Console.WriteLine("\n=== Dimensiones de la Matriz B ===");
            int filasB = ObtenerFila();
            int columnasB = ObtenerColumna();

            if (columnasA != filasB)
            {
                Console.WriteLine("\n[Error Matematico]: No se pueden multiplicar las matrices.");
                Console.WriteLine($"No es posible multiplicar una matriz de {filasA}x{columnasA} con una de {filasB}x{columnasB}.");
                Console.WriteLine("El número de columnas de la Matriz A debe ser IGUAL al número de filas de la Matriz B.");
                return; // Finaliza la ejecución si no es válido
            }

            int[,] matrizA = GenerarMatriz(filasA, columnasA, "Matriz A");
            int[,] matrizB = GenerarMatriz(filasB, columnasB, "Matriz B");

            int[,] matrizResultado = MultiplicarMatrices(matrizA, matrizB);

            MostrarMatriz(matrizA, "Matriz A");
            MostrarMatriz(matrizB, "Matriz B");
            MostrarMatriz(matrizResultado, "Matriz Resultado (Producto)");

        }
    }
}

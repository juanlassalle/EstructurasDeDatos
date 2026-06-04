using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Ejercicio
{
    internal class Program
    {
        //Realice un algoritmo para obtener una matriz como el resultado de la
        //suma de dos matrices de orden M x N.
        static void Main(string[] args)
        {
            Resultados();
        }
        private static int[,] GenerarMatriz(int _fila,int _columna)
        {
            int[,] matriz = new int[_fila, _columna];

            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write($"Ingresar elemento [{f + 1},{c + 1}]: ");
                    matriz[f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matriz; 
        }
        private static int[,] SumaMatriz(int[,] _matrizA, int[,] _matrizB)
        {
            int[,] matrizC = new int[_matrizA.GetLength(0), _matrizA.GetLength(1)];

            for (int f = 0; f < _matrizA.GetLength(0); f++)
            {
                for (int c = 0; c < _matrizA.GetLength(1); c++)
                {
                    matrizC[f, c] = _matrizA[f, c] + _matrizB[f, c];
                }
            }

            return matrizC;
        }
        private static void MostrarMatriz(int[,] _matriz)
        {
            Console.WriteLine("\n========== Matriz Resultado (Suma) ==========");
            for (int f = 0; f < _matriz.GetLength(0); f++)
            {
                for (int c = 0; c < _matriz.GetLength(1); c++)
                {
                    Console.Write(_matriz[f, c] + "\t"); // \t añade un espacio de tabulación
                }
                Console.WriteLine(); // Salto de línea al terminar una fila
            }
        }
        private static void Resultados()
        {
            Console.WriteLine("========== Dimensiones de las Matrices (M x N) ==========");
            Console.Write("Ingresar la cantidad de filas (M): ");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar la cantidad de columnas (N): ");
            int columnas = Convert.ToInt32(Console.ReadLine());

            // Creamos y llenamos la Matriz A y la Matriz B
            Console.WriteLine("\n--- Llenado de la Matriz A ---");
            int[,] matrizA = GenerarMatriz(filas, columnas);

            Console.WriteLine("\n--- Llenado de la Matriz B ---");
            int[,] matrizB = GenerarMatriz(filas, columnas);

            // Sumamos las matrices
            int[,] matrizResultado = SumaMatriz(matrizA, matrizB);

            // Mostramos el resultado
            MostrarMatriz(matrizResultado);
        }
    }
}

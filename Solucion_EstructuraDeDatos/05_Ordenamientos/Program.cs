using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Ordenamientos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos arreglos de prueba idénticos para cada algoritmo
            int[] datosBubble = { 5, 1, 4, 2, 8, 3 };
            int[] datosInsertion = { 5, 1, 4, 2, 8, 3 };
            int[] datosSelection = { 5, 1, 4, 2, 8, 3 };

            Console.WriteLine("--- Probando Algoritmos de Ordenamiento ---\n");

            // 1. Bubble Sort
            Console.WriteLine("Original: " + string.Join(", ", datosBubble));
            BubbleSort(datosBubble);
            Console.WriteLine("Bubble Sort: " + string.Join(", ", datosBubble) + "\n");

            // 2. Insertion Sort
            Console.WriteLine("Original: " + string.Join(", ", datosInsertion));
            InsertionSort(datosInsertion);
            Console.WriteLine("Insertion Sort: " + string.Join(", ", datosInsertion) + "\n");

            // 3. Selection Sort
            Console.WriteLine("Original: " + string.Join(", ", datosSelection));
            SelectionSort(datosSelection);
            Console.WriteLine("Selection Sort: " + string.Join(", ", datosSelection) + "\n");
        }

        /// <summary>
        /// Bubble Sort optimizado con una bandera (swapped).
        /// </summary>
        static void BubbleSort(int[] _arr)
        {
            int n = _arr.Length;
            bool intercambiado;

            for (int i = 0; i < n - 1; i++)
            {
                intercambiado = false;
                // El bucle interno llega hasta n - i - 1 porque los últimos 'i' elementos ya están ordenados
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (_arr[j] > _arr[j + 1])
                    {
                        // Intercambio clásico usando una variable temporal
                        int temp = _arr[j];
                        _arr[j] = _arr[j + 1];
                        _arr[j + 1] = temp;
                        intercambiado = true;
                    }
                }

                // Si en toda una pasada no hubo intercambios, el arreglo ya está ordenado
                if (!intercambiado)
                    break;
            }
        }

        /// <summary>
        /// Insertion Sort: Inserta cada elemento en su posición correcta de la sublista ordenada.
        /// </summary>
        static void InsertionSort(int[] _arr)
        {
            int n = _arr.Length;
            for (int i = 1; i < n; i++)
            {
                int llave = _arr[i]; // El elemento que vamos a posicionar
                int j = i - 1;

                // Desplazamos los elementos de la parte ordenada que sean mayores que la 'llave'
                while (j >= 0 && _arr[j] > llave)
                {
                    _arr[j + 1] = _arr[j];
                    j--;
                }
                // Colocamos la llave en su lugar correcto
                _arr[j + 1] = llave;
            }
        }

        /// <summary>
        /// Selection Sort: Busca el mínimo y lo coloca al principio.
        /// </summary>
        static void SelectionSort(int[] _arr)
        {
            int n = _arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int indiceMinimo = i;

                // Buscamos el elemento más chico en el resto del arreglo desordenado
                for (int j = i + 1; j < n; j++)
                {
                    if (_arr[j] < _arr[indiceMinimo])
                    {
                        indiceMinimo = j;
                    }
                }

                // Intercambiamos el mínimo encontrado con el elemento de la posición 'i'
                int temp = _arr[indiceMinimo];
                _arr[indiceMinimo] = _arr[i];
                _arr[i] = temp;
            }
        }
    }
}

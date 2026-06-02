using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayBase = { 38, 27, 43, 3, 9, 82, 10, 19, 50, 4 };

            Console.WriteLine("=== PRUEBA DE ALGORITMOS EN PROGRAM.CS (C# <= 8.0) ===");
            Console.WriteLine("Original: " + string.Join(", ", arrayBase) + "\n");

            // --- PRUEBA 1: MERGE SORT ---
            int[] arrayMerge = (int[])arrayBase.Clone();
            MergeSort(arrayMerge, 0, arrayMerge.Length - 1);
            Console.WriteLine("[Merge Sort]  Resultado: " + string.Join(", ", arrayMerge));

            // --- PRUEBA 2: QUICK SORT ---
            int[] arrayQuick = (int[])arrayBase.Clone();
            QuickSort(arrayQuick, 0, arrayQuick.Length - 1);
            Console.WriteLine("[Quick Sort]  Resultado: " + string.Join(", ", arrayQuick));

            // --- PRUEBA 3: HEAP SORT ---
            int[] arrayHeap = (int[])arrayBase.Clone();
            HeapSort(arrayHeap);
            Console.WriteLine("[Heap Sort]   Resultado: " + string.Join(", ", arrayHeap));

            Console.WriteLine("\n========================================================");

            // Para mantener abierta la consola en proyectos de consola antiguos
            Console.ReadLine();
        }
        // =================================================================
        // 2. MÉTODOS ESTÁTICOS DE LOS ALGORITMOS
        // =================================================================

        // --- LÓGICA DE MERGE SORT ---
        static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }
        }

        static void Merge(int[] array, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(array, left, leftArray, 0, leftArray.Length);
            Array.Copy(array, middle + 1, rightArray, 0, rightArray.Length);

            int i = 0, j = 0, k = left;

            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k++] = leftArray[i++];
                }
                else
                {
                    array[k++] = rightArray[j++];
                }
            }

            while (i < leftArray.Length) array[k++] = leftArray[i++];
            while (j < rightArray.Length) array[k++] = rightArray[j++];
        }


        // --- LÓGICA DE QUICK SORT ---
        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);

                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, high);
            return i + 1;
        }


        // --- LÓGICA DE HEAP SORT ---
        static void HeapSort(int[] array)
        {
            int n = array.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                Swap(array, 0, i);
                Heapify(array, i, 0);
            }
        }

        static void Heapify(int[] array, int size, int rootIndex)
        {
            int largest = rootIndex;
            int leftChild = 2 * rootIndex + 1;
            int rightChild = 2 * rootIndex + 2;

            if (leftChild < size && array[leftChild] > array[largest])
                largest = leftChild;

            if (rightChild < size && array[rightChild] > array[largest])
                largest = rightChild;

            if (largest != rootIndex)
            {
                Swap(array, rootIndex, largest);
                Heapify(array, size, largest);
            }
        }


        // --- FUNCIÓN AUXILIAR COMPARTIDA ---
        static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}

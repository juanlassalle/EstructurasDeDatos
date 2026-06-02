using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ListaEnlazada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Crear la lista enlazada (en este caso de textos/strings)
            LinkedList<string> listaReproduccion = new LinkedList<string>();

            // 2. Agregar elementos (Nodos)
            listaReproduccion.AddLast("Canción B"); // Agrega al final
            listaReproduccion.AddLast("Canción C");
            listaReproduccion.AddFirst("Canción A"); // Agrega al principio

            Console.WriteLine("--- Lista inicial ---");
            ImprimirLista(listaReproduccion);
            // Salida: Canción A -> Canción B -> Canción C

            // 3. Buscar un nodo específico
            LinkedListNode<string> nodoB = listaReproduccion.Find("Canción B");

            // 4. Insertar elementos usando una referencia (ventaja de listas dobles)
            if (nodoB != null)
            {
                // Insertamos una canción justo después de la "Canción B"
                listaReproduccion.AddAfter(nodoB, "Canción Intermedia");
            }

            Console.WriteLine("\n--- Después de insertar intercalado ---");
            ImprimirLista(listaReproduccion);
            // Salida: Canción A -> Canción B -> Canción Intermedia -> Canción C

            // 5. Eliminar elementos de forma muy sencilla
            listaReproduccion.Remove("Canción A"); // Eliminar por valor
            listaReproduccion.RemoveLast();         // Eliminar la última automáticamente

            Console.WriteLine("\n--- Después de eliminar la primera y la última ---");
            ImprimirLista(listaReproduccion);
            // Salida: Canción B -> Canción Intermedia
        }
        // Método auxiliar para imprimir la lista nativa de C#
        public static void ImprimirLista(LinkedList<string> lista)
        {
            foreach (string cancion in lista)
            {
                Console.Write(cancion + " -> ");
            }
            Console.WriteLine("FIN");
        }
    }
}

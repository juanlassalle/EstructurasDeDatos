using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ArbolesBin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();

            // 1. Creamos la raíz
            arbol.Raiz = new Nodo(1);

            // 2. Asignamos los hijos de la raíz
            arbol.Raiz.Izquierdo = new Nodo(2);
            arbol.Raiz.Derecho = new Nodo(3);

            // 3. Asignamos un hijo al nodo 2
            arbol.Raiz.Izquierdo.Izquierdo = new Nodo(4);

            // 4. Mostramos el árbol usando nuestro recorrido
            Console.WriteLine("Recorrido En-Orden del árbol:");
            arbol.RecorrerEnOrden(arbol.Raiz);
            // Salida esperada: 4 2 1 3
        }
    }
}

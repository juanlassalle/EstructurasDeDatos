using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ListaEnlazadaSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaSimple miLista = new ListaEnlazadaSimple();

            miLista.AgregarAlFinal(10);
            miLista.AgregarAlFinal(20);
            miLista.AgregarAlInicio(5);
            miLista.AgregarAlFinal(30);

            // Debería imprimir: 5 -> 10 -> 20 -> 30 -> null
            miLista.ImprimirLista();
            // Eliminamos un nodo intermedio (20)
            //miLista.Eliminar(20);
            //Console.WriteLine("\nDespués de eliminar el 20:");
            //miLista.ImprimirLista(); // 10 -> 30 -> 40 -> null

            //// Eliminamos la cabeza (10)
            //miLista.Eliminar(10);
            //Console.WriteLine("\nDespués de eliminar la cabeza (10):");
            //miLista.ImprimirLista(); // 30 -> 40 -> null
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioBusqueda bst = new ArbolBinarioBusqueda();

            // Insertamos datos en un orden completamente caótico
            bst.Insertar(50);
            bst.Insertar(30);
            bst.Insertar(70);
            bst.Insertar(20);
            bst.Insertar(40);
            bst.Insertar(60);
            bst.Insertar(80);

            // Visualmente, la estructura interna que el código acaba de armar es:
            //          50
            //        /    \
            //       30    70
            //      /  \  /  \
            //     20  40 60  80

            Console.WriteLine("Contenido del BST (Recorrido In-Order):");
            bst.ImprimirEnOrden(bst.Raiz);

            // SALIDA ESPERADA: 20 30 40 50 60 70 80
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ArbolesBin
{
    internal class ArbolBinario
    {
        public Nodo Raiz { get; set; }

        public ArbolBinario()
        {
            Raiz = null;
        }

        // Método auxiliar para imprimir el árbol en consola (In-Order)
        public void RecorrerEnOrden(Nodo nodoActual)
        {
            if (nodoActual != null)
            {
                RecorrerEnOrden(nodoActual.Izquierdo);  // Visita subárbol izquierdo
                Console.Write(nodoActual.Valor + " ");   // Visita la raíz/nodo actual
                RecorrerEnOrden(nodoActual.Derecho);    // Visita subárbol derecho
            }
        }
    }
}

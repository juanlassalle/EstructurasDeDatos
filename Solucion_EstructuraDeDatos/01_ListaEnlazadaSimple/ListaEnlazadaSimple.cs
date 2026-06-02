using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ListaEnlazadaSimple
{
    internal class ListaEnlazadaSimple
    {
        public Nodo Cabeza { get; private set; } // El inicio de la lista

        public ListaEnlazadaSimple()
        {
            Cabeza = null; // Inicialmente la lista está vacía
        }

        // Método para agregar un nodo al FINAL de la lista
        public void AgregarAlFinal(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);

            // Si la lista está vacía, el nuevo nodo es la cabeza
            if (Cabeza == null)
            {
                Cabeza = nuevoNodo;
                return;
            }

            // Si no está vacía, viajamos hasta el último nodo
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            // Hacemos que el último nodo apunte al nuevo
            actual.Siguiente = nuevoNodo;
        }

        // Método para agregar un nodo al INICIO de la lista
        public void AgregarAlInicio(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            nuevoNodo.Siguiente = Cabeza; // El nuevo nodo apunta a la antigua cabeza
            Cabeza = nuevoNodo;           // La cabeza ahora es el nuevo nodo
        }

        // Método para imprimir la lista en consola
        public void ImprimirLista()
        {
            Nodo actual = Cabeza;
            while (actual != null)
            {
                Console.Write(actual.Valor + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
        public void Eliminar(int valor)
        {
            // Caso 0: La lista está vacía
            if (Cabeza == null) return;

            // Caso 1: El nodo a eliminar es la Cabeza
            if (Cabeza.Valor == valor)
            {
                Cabeza = Cabeza.Siguiente; // La cabeza ahora es el siguiente elemento
                return;
            }

            // Caso 2: El nodo está en medio o al final
            Nodo actual = Cabeza;

            // Buscamos el nodo ANTERIOR al que queremos eliminar
            while (actual.Siguiente != null && actual.Siguiente.Valor != valor)
            {
                actual = actual.Siguiente;
            }

            // Si encontramos el nodo (es decir, actual.Siguiente no es null)
            if (actual.Siguiente != null)
            {
                // "Saltamos" el nodo intermedio cambiando la referencia
                actual.Siguiente = actual.Siguiente.Siguiente;
            }
        }
    }
}

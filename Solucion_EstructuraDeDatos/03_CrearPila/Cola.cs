using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CrearPila
{
    internal class Cola<T>
    {
        private Nodo<T> frente; // El primero de la fila (de acá se sale)
        private Nodo<T> final;  // El último de la fila (acá se entra)

        public int Contador { get; private set; } // Para saber cuántos hay

        // ENQUETE: Agregar al final
        public void Encolar(T elemento)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(elemento);

            if (final != null)
            {
                // El que era el último ahora apunta al nuevo que llega
                final.Siguiente = nuevoNodo;
            }

            // El nuevo nodo pasa a ser el final oficial
            final = nuevoNodo;

            // Si la cola estaba vacía, el primero también es el nuevo nodo
            if (frente == null)
            {
                frente = nuevoNodo;
            }

            Contador++;
        }

        // DEQUEUE: Sacar del frente
        public T Desencolar()
        {
            if (frente == null)
            {
                throw new InvalidOperationException("La cola está vacía, che.");
            }

            // Guardamos el valor que vamos a devolver
            T valorRetorno = frente.Valor;

            // Movemos el frente al siguiente de la fila
            frente = frente.Siguiente;

            // Si el frente quedó vacío, significa que la cola se vació por completo
            if (frente == null)
            {
                final = null;
            }

            Contador--;
            return valorRetorno;
        }

        // PEEK: Mirar el frente sin sacar
        public T Mirar()
        {
            if (frente == null)
            {
                throw new InvalidOperationException("No hay nadie en la cola.");
            }
            return frente.Valor;
        }
    }
}

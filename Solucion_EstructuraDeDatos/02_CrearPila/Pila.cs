using System;


namespace _02_CrearPila
{
    internal class Pila<T>
    {
        private T[] items;
        private int cima; // Apunta al índice del último elemento insertado
        private const int CapacidadInicial = 4;

        public Pila()
        {
            items = new T[CapacidadInicial];
            cima = -1; // -1 significa que la pila está vacía
        }

        // Propiedad para saber cuántos elementos hay
        public int Cantidad => cima + 1;

        // OPERACIÓN 1: Push (Apilar)
        public void Push(T item)
        {
            // Si el array se llenó, duplicamos su tamaño
            if (cima == items.Length - 1)
            {
                Redimensionar(items.Length * 2);
            }

            cima++;
            items[cima] = item;
        }

        // OPERACIÓN 2: Pop (Desapilar)
        public T Pop()
        {
            if (cima == -1)
            {
                throw new InvalidOperationException("La pila está vacía. No se puede hacer Pop.");
            }

            T item = items[cima];

            // Limpiamos la posición para ayudar al Garbage Collector (recolector de basura)
            items[cima] = default(T);
            cima--;

            return item;
        }

        // OPERACIÓN 3: Peek (Espiar)
        public T Peek()
        {
            if (cima == -1)
            {
                throw new InvalidOperationException("La pila está vacía. No se puede hacer Peek.");
            }

            return items[cima];
        }

        // Método auxiliar para agrandar el array cuando se llene
        private void Redimensionar(int _nuevaCapacidad)
        {
            T[] nuevoArray = new T[_nuevaCapacidad];
            Array.Copy(items, nuevoArray, items.Length);
            items = nuevoArray;
        }
    }
}

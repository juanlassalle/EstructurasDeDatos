using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioBusqueda
{
    internal class ArbolBinarioBusqueda
    {
        public Nodo Raiz { get; set; }

        public ArbolBinarioBusqueda()
        {
            Raiz = null;
        }

        // 1. Método público que llama el usuario
        public void Insertar(int _valor)
        {
            Raiz = InsertarRecursivo(Raiz, _valor);
        }

        // 2. El "motor" recursivo que busca el lugar correcto
        private Nodo InsertarRecursivo(Nodo _nodoActual, int _valor)
        {
            // Si llegamos a un espacio vacío, aquí es donde va el nuevo nodo
            if (_nodoActual == null)
            {
                return new Nodo(_valor);
            }

            // Si el valor es MENOR, disparamos hacia la izquierda
            if (_valor < _nodoActual.Valor)
            {
                _nodoActual.Izquierdo = InsertarRecursivo(_nodoActual.Izquierdo, _valor);
            }
            // Si el valor es MAYOR, disparamos hacia la derecha
            else if (_valor > _nodoActual.Valor)
            {
                _nodoActual.Derecho = InsertarRecursivo(_nodoActual.Derecho, _valor);
            }

            // Si el valor ya existe, simplemente no lo duplicamos y devolvemos el nodo actual
            return _nodoActual;
        }

        // Método para imprimir el árbol y comprobar el orden
        public void ImprimirEnOrden(Nodo nodoActual)
        {
            if (nodoActual != null)
            {
                ImprimirEnOrden(nodoActual.Izquierdo);
                Console.Write(nodoActual.Valor + " ");
                ImprimirEnOrden(nodoActual.Derecho);
            }
        }
    }
}

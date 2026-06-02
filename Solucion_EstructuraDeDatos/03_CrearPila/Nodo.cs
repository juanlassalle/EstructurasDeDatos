using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CrearPila
{
    internal class Nodo<T>
    {
        public T Valor { get; set; }
        public Nodo<T> Siguiente { get; set; }

        public Nodo(T valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }
}

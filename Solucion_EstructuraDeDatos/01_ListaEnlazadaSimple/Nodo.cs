using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ListaEnlazadaSimple
{
    internal class Nodo
    {
        public int Valor { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(int _valor)
        {
            Valor = _valor;
            Siguiente = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ejercicio
{
    internal class Program
    {
        //En un arreglo se tienen registradas las ventas de cinco empleados durante
        //cinco días de la semana. Se requiere determinar cuál fue la venta mayor
        //realizada.
        static void Main(string[] args)
        {
            CalcularVentaMayor();
        }
        private static decimal[,] Venta()
        {
            decimal[,] venta = new decimal[5, 5];

            for (int f = 0; f < venta.GetLength(0) ; f++)
            {
                for (int c = 0; c < venta.GetLength(1); c++)
                {
                    Console.Write($"Ingresar venta en la coordenada [{f},{c}]: ");
                    venta[f, c] = Convert.ToDecimal(Console.ReadLine());
                }
            }

            return venta;
        }
        private static void CalcularVentaMayor()
        {
            decimal[,] ventas = Venta();
            decimal may = ventas[0, 0];

            for (int f = 0; f < ventas.GetLength(0); f++)
            {
                for (int c = 0; c < ventas.GetLength(1); c++)
                {
                    if (ventas[f,c] > may)
                    {
                        may = ventas[f, c];
                    }
                }
            }

            Console.WriteLine($"\nLa venta mayor de los cinco empleados es: {may}");
        }
    }
}

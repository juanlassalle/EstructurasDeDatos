using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ejercicio
{
    internal class Program
    {
        //Cierta empresa requiere controlar la existencia de diez productos, los cuales
        //se almacenan en un vector A, mientras que los pedidos de los clientes
        //de estos productos se almacenan en un vector B. Se requiere generar un
        //tercer vector C con base en los anteriores que represente lo que se requiere
        //comprar para mantener el stock de inventario, para esto se considera lo
        //siguiente: si los valores correspondientes de los vectores A y B son iguales
        //se almacena este mismo valor, si el valor de B es mayor que el de A se almacena
        //el doble de la diferencia entre B y A, si se da el caso de que A es mayor
        //que B, se almacena B, que indica lo que se requiere comprar para mantener
        //el stock de inventario.
        private static int[] vectorA = new int[10];
        private static int[] vectorB = new int[10];
        private static int[] vectorC = new int[10];
        static void Main(string[] args)
        {
            IngresarDatos();
            Inventario();
            ImprimirResultados();

            Console.ReadLine();
        }
        private static void IngresarDatos()
        {
            Console.WriteLine("==== INVENTARIO EXISTENTE (VECTOR A) ====");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Producto #{i + 1} - Unidades en stock: ");
                vectorA[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("==== PEDIDOS DE CLIENTES (VECTOR B) ====");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Producto #{i + 1} - Unidades pedidas: ");
                vectorB[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        private static void Inventario()
        {
            for (int i = 0; i < 10; i++)
            {
                if (vectorA[i] == vectorB[i])
                {
                    vectorC[i] = vectorA[i];
                }
                else if (vectorB[i] > vectorA[i])
                {
                    vectorC[i] = 2 * (vectorB[i] - vectorA[i]);
                }
                else
                {
                    vectorC[i] = vectorB[i];
                }
            }
        }
        private static void ImprimirResultados()
        {
            Console.WriteLine("========== REPORTE FINAL DE COMPRAS ==========");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("{0,-10} | {1,-10} | {2,-10} | {3,-10}", "Producto", "Stock (A)", "Pedido (B)", "Comprar (C)");
            Console.WriteLine("--------------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0,-10} | {1,-10} | {2,-10} | {3,-10}", $"# {i + 1}", vectorA[i], vectorB[i], vectorC[i]);
            }
            Console.WriteLine("--------------------------------------------");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> historialWeb = new Stack<string>();

            Console.WriteLine("--- Navegando por internet ---");

            // 1. Usamos Push para agregar páginas a la pila
            historialWeb.Push("google.com");
            historialWeb.Push("github.com");
            historialWeb.Push("stackoverflow.com");

            // 2. Usamos Count para ver cuántas páginas visitamos
            Console.WriteLine($"Páginas en el historial: {historialWeb.Count}");

            // 3. Usamos Peek para ver cuál es la página actual (la última que entró)
            Console.WriteLine($"Página actual en pantalla: {historialWeb.Peek()}");

            Console.WriteLine("\n--- El usuario presiona el botón 'Atrás' ---");

            // 4. Usamos Pop para salir de la página actual y regresar a la anterior
            string paginaSalida = historialWeb.Pop();
            Console.WriteLine($"Saliendo de: {paginaSalida}");

            // Ahora la cima de la pila cambió
            Console.WriteLine($"Nueva página actual en pantalla: {historialWeb.Peek()}");

            Console.WriteLine($"Páginas restantes en el historial: {historialWeb.Count}");
        }
    }
}

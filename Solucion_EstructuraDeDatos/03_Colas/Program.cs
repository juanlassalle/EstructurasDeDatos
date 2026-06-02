using System;
using System.Collections.Generic;

namespace _03_Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Creamos una cola de strings para los clientes
            Queue<string> filaBanco = new Queue<string>();

            Console.WriteLine("--- Llegan los clientes ---");

            // 2. Encolar elementos (Enqueue)
            filaBanco.Enqueue("Carlos");
            filaBanco.Enqueue("María");
            filaBanco.Enqueue("José");

            Console.WriteLine($"Clientes en espera: {filaBanco.Count}"); // Muestra 3

            Console.WriteLine("\n--- Atendiendo ---");

            // 3. Mirar quién sigue sin sacarlo (Peek)
            Console.WriteLine($"El próximo a ser atendido es: {filaBanco.Peek()}"); // Carlos

            // 4. Desencolar (Dequeue) - Carlos pasa a la caja
            string atendido1 = filaBanco.Dequeue();
            Console.WriteLine($"Se atendió a: {atendido1}");

            // ¿Quién quedó primero ahora?
            Console.WriteLine($"El siguiente en la fila ahora es: {filaBanco.Peek()}"); // María

            // Atendemos al resto usando un bucle mientras la cola no esté vacía
            Console.WriteLine("\n--- Despachando al resto ---");
            while (filaBanco.Count > 0)
            {
                string cliente = filaBanco.Dequeue();
                Console.WriteLine($"Atendido: {cliente}");
            }

            Console.WriteLine($"\nFila vacía. Clientes restantes: {filaBanco.Count}");
        }
    }
}

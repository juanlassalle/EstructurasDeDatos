using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CrearPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola<string> controlRemoto = new Cola<string>();

            // Encolamos
            controlRemoto.Encolar("Comando 1: Encender");
            controlRemoto.Encolar("Comando 2: Subir Volumen");
            controlRemoto.Encolar("Comando 3: Cambiar Canal");

            Console.WriteLine($"Elementos en cola: {controlRemoto.Contador}"); // 3
            Console.WriteLine($"Siguiente comando en espera: {controlRemoto.Mirar()}"); // Comando 1

            // Procesamos (Desencolamos)
            Console.WriteLine($"\nEjecutando: {controlRemoto.Desencolar()}"); // Ejecuta Comando 1
            Console.WriteLine($"Ejecutando: {controlRemoto.Desencolar()}"); // Ejecuta Comando 2

            Console.WriteLine($"\nQuedaron pendientes: {controlRemoto.Contador}"); // 1
        }
    }
}

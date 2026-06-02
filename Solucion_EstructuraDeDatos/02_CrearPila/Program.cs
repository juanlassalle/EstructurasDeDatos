using System;

namespace _02_CrearPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila<int> numeros = new Pila<int>();
            // Apilamos números
            numeros.Push(10);
            numeros.Push(20);
            numeros.Push(30);
            numeros.Push(40); // Aquí alcanzó la capacidad inicial (4)
            numeros.Push(50); // ¡Aquí se redimensiona automáticamente a capacidad 8!

            Console.WriteLine($"Elementos en la pila: {numeros.Cantidad}"); // Imprime 5
            Console.WriteLine($"Elemento en la cima (Peek): {numeros.Peek()}"); // Imprime 50

            // Desapilamos dos veces
            Console.WriteLine($"Sacando: {numeros.Pop()}"); // Imprime 50
            Console.WriteLine($"Sacando: {numeros.Pop()}"); // Imprime 40

            Console.WriteLine($"Nueva cima: {numeros.Peek()}"); // Imprime 30
        }
    }
}

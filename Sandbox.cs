using System;
using System.Collections.Generic;

namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Pruebas en Sandbox ===");

            // Prueba de StackFirstPrime
            Stack<uint> pilaPrueba = new Stack<uint>(new uint[] { 10, 15, 23, 8, 30 });
            Console.WriteLine("Primer número primo en la pila: " + TestMethods.StackFirstPrime(pilaPrueba));

            // Prueba de RemoveFirstPrime
            Stack<uint> pilaSinPrimos = TestMethods.RemoveFirstPrime(new Stack<uint>(pilaPrueba));
            Console.WriteLine("Pila después de eliminar el primer número primo:");
            foreach (var num in pilaSinPrimos)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Prueba de CreateQueueFromStack
            Queue<uint> cola = TestMethods.CreateQueueFromStack(pilaPrueba);
            Console.WriteLine("Cola creada desde la pila:");
            foreach (var num in cola)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Prueba de StackToList
            List<uint> lista = TestMethods.StackToList(pilaPrueba);
            Console.WriteLine("Lista creada desde la pila:");
            foreach (var num in lista)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Prueba de FoundElementAfterSorted
            List<int> listaNumeros = new List<int> { 45, 12, 78, 34, 90, 23 };
            int valorBuscado = 34;
            Console.WriteLine($"¿El número {valorBuscado} está en la lista ordenada? {TestMethods.FoundElementAfterSorted(listaNumeros, valorBuscado)}");
        }
    }
}
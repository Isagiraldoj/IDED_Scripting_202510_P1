using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        // Función para encontrar el primer número primo en la pila
        internal static uint StackFirstPrime(Stack<uint> stack)
        {
            foreach (uint num in stack)
            {
                if (EsPrimo(num))
                    return num;
            }
            return 0;
        }

        // Función para eliminar el primer número primo encontrado en la pila
        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {
            Stack<uint> tempStack = new Stack<uint>();
            bool found = false;

            while (stack.Count > 0)
            {
                uint num = stack.Pop();
                if (!found && EsPrimo(num))
                {
                    found = true;
                    continue;
                }
                tempStack.Push(num);
            }

            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }

            return stack;
        }

        // Función para crear una cola a partir de los elementos de la pila
        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)
        {
            Queue<uint> queue = new Queue<uint>();
            Stack<uint> tempStack = new Stack<uint>(stack); 
            while (tempStack.Count > 0)
            {
                queue.Enqueue(tempStack.Pop());
            }

            return queue;
        }

        // Función para convertir la pila en una lista
        internal static List<uint> StackToList(Stack<uint> stack)
        {
            List<uint> list = new List<uint>();

           
            foreach (uint num in stack)
            {
                list.Insert(0, num); 
            }

            return list;
        }
        // Función para determinar si un número se encuentra en la lista después de ordenar
        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            foreach (int num in list)
            {
                if (num == value)
                    return true;
            }
            return false;
        }

        // Función para verificar si un número es primo
        private static bool EsPrimo(uint num)
        {
            if (num < 2) return false;
            for (uint i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
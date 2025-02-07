using System;
using System.Collections.Generic;
/*Crea un programa que pida al usuario 5 números enteros y luego los
muestre en orden contrario, utilizando una pila.*/
class Program
{
    static void Main()
    {
        Stack<int> miPila = new Stack<int>();
        for (byte i = 0; i < 5; i++)
        {
            Console.Write("Introduce un número: ");
            miPila.Push(Convert.ToInt32(Console.ReadLine()));
        }
        for (byte i = 0; i < 5; i++)
        {
            Console.WriteLine(miPila.Pop());
        }
    }
}

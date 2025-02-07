using System;
using System.Collections.Generic;
/*Crea un programa que pida al usuario 5 números reales de doble precisión,
los guarde en una cola y luego los muestre en pantalla*/
class Program
{
    static void Main()
    {
        int n = 0;
        Queue<int> miCola = new Queue<int>();
        do
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.Write("Dime un numero entero: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n != 0)
                        miCola.Enqueue(n);
                }
                catch (FormatException)
                {
                    Console.WriteLine("No has introducido un número entero.");
                    n = 1;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("El número es demasiado grande.");
                    n = 1;
                }
            }
            
        } while (n != 0);
        Console.Write("Los datos eran: ");
        while (miCola.Count > 0)
            Console.Write("{0} ", miCola.Dequeue());
    }
}

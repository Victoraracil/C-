using System;
/*
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */
public class Program
{
    public static void Main(string[] args)
    {
        EsPrimo();
    }
    public static void EsPrimo()
    {
        for (int i = 1; i < 100; i++)
        {
            int primo = 0;
            for(int j = 1; j < 100; j++)
            {
                if (i % j == 0)
                {
                    primo++;
                }
            }
            if (primo == 2) { Console.WriteLine(i); }
        }
    }
}
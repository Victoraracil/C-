using System;
using System.Collections.Generic;
/*Crea una clase que imite el comportamiento de una pila, pero usando
internamente un array (si no lo consigues, no te preocupes; en un apartado
posterior veremos una forma de hacerlo).*/

class Program
{
    public static void Main(string[] args)
    {
        int tamaño = 5;
        do
        {
            Console.WriteLine("Quieres introducir numeros en la pila? SI (ENTER) / NO (ESC)");
            PilaFalsa pila = new PilaFalsa(5);
            if (pila.GetTamaño() == tamaño - 1)
            {
                PilaFalsa pilaFalsa = new PilaFalsa(tamaño * 2);
                for (int i = 0; i < tamaño; i++)
                {
                    pilaFalsa.SetNumero(pila.GetNumero(i), i);
                    PilaFalsa pila =  new PilaFalsa(tamaño * 2);
                }
                pila = null;
            }
            else
            {
                for (int i = tamaño; i < tamaño; i++)
                {
                    Console.WriteLine("Introduce un numero:");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    pila.SetNumero(numero, i);
                }
                pila.MostrarPila();
            }
            Console.Clear();
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
        

            

    }
}

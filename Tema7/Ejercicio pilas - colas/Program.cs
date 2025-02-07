using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        List<string> lista = new List<string>();
        Pilas pila = new Pilas();
        Colas cola = new Colas();


        program.MostrarMenuPrincipal(lista, pila, cola);
    }
    public void MostrarMenuPrincipal(List <string> lista, Pilas pila, Colas cola)
    {
        string op;
        do
        {
            Console.Clear();
            Console.WriteLine("0 - Salir");
            Console.WriteLine("1 - Trabajar con pilas");
            Console.WriteLine("2 - Trabajar con colas");

            op = Console.ReadLine();

            switch (op)
            {
                case "0": break;
                case "1":
                    pila.MostrarMenu(this, lista); break;
                case "2":
                    cola.MostrarMenu(this, lista); break;
                default: Console.WriteLine("Opción incorrecta"); break;
            }
        } while (op != "0");
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*Crea una pila de "doubles", usando internamente un ArrayList (o una lista
con tipo) en vez de un array.*/
class Program
{
    static void Main()
    {
        ListaOrdenada listaordenada = new ListaOrdenada();
        string opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Obtener");
            Console.WriteLine("3. Borrar");
            Console.WriteLine("4. Ordenar");
            Console.WriteLine("5. Salir");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Introduce un dato:");
                    try
                    {
                        listaordenada.Insertar(Convert.ToInt32(Console.ReadLine()));
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("No puedes insertar texto, solo numeros");
                    }
                    break;
                case "2":
                    Console.WriteLine("Introduce la posicion del dato que quieras obtener:");
                    Console.WriteLine(listaordenada.Obtener(Convert.ToInt32(Console.ReadLine())));
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Introduce la posicion del dato que quieras borrar:");
                    listaordenada.Borrar(Convert.ToInt32(Console.ReadLine()));
                    Console.ReadLine();
                    break;
                case "4":
                    listaordenada.Ordenar();
                    Console.ReadLine();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }
        } while (opcion != "4");
    }
}

 
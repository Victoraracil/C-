using System;
using System.Collections.Generic;
/*Crea una clase "ListaOrdenada" de "strings", que almacene un único dato
(no un par clave-valor como los SortedList). Debe utilizar internamente un array,
contener un método "Insertar", que añadirá un nuevo dato en orden en el array,
un "Obtener(n)", que obtenga un elemento de la lista (el número "n") sin borrarlo
de la lista, y un "Borrar(n)", que elimine el n-ésimo elemento. Deberá almacenar
"strings".*/
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
            Console.WriteLine("4. Salir");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Introduce un dato:");
                    listaordenada.Insertar(Console.ReadLine());
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
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }
        } while (opcion != "4");
    }
}


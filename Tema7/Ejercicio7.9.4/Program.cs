using System;
using System.Collections.Generic;
using System.Collections;
/*Crea una cola que almacene un bloque de datos (struct, con los campos
que tú elijas) usando una lista con tipo*/
class Program
{
    struct Coche
    {
        string marca;
        string modelo;
        int ruedas;
        float potencia;
        bool ITV;
    }
    public static void Main(string[] args)
    {
        string opcion;
        Queue <Coche> coches = new Queue <Coche>();
        do
        {
            Console.WriteLine("1. Añadir nuevo coche");
            Console.WriteLine("2. Obtener coche");
            Console.WriteLine("3. Borrar coche");
            Console.WriteLine("4. Salir");

            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    coches.Enqueue();
                    break;
            }
        } while (opcion != "4");
        

    }
}

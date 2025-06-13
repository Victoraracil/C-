using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        string op;
        GrupoDeDinosaurios grupo = new GrupoDeDinosaurios();

        do
        {   
            Console.Clear();
            Console.WriteLine("0 - Salir");
            Console.WriteLine("1 - Añadir dinosaurios");
            Console.WriteLine("2 - Borrar todos los dinosaurios");
            Console.WriteLine("3 - Borar dinosaurio por nombre");
            Console.WriteLine("4 - Mostrar todos los dinosaurios");
            Console.WriteLine("5 - Mostrar dinosaurios por nombre");
            Console.WriteLine("6 - Mostrar dinosaurios por nombre, peso y longitud");
            Console.WriteLine("7 - Ordenar dinosaurios");
            
            op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    int peso;
                    float longitud;

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Peso (entre 0 y 70000): ");
                    while (!int.TryParse(Console.ReadLine(), out peso))
                    {
                        Console.WriteLine("Dato incorrecto");
                    }
                    if (peso < 0 || peso > 70000)
                    {
                        peso = 0;
                    }

                    Console.Write("Longitud (entre 0 y 50): ");
                    while (!float.TryParse(Console.ReadLine(), out longitud))
                    {
                        Console.WriteLine("Dato incorrecto");
                    }
                    if (longitud < 0 || longitud > 50)
                    {
                        longitud = 0;
                    }

                    grupo.AnyadirDinosaurio(nombre, peso, longitud);
                    break;
                case "2":
                    grupo.BorrarTodos();
                    break;
                case "3":
                    Console.WriteLine("Introduce el nombre del dinosaurio a eliminar");
                    nombre = Console.ReadLine();

                    Console.WriteLine("Se han eliminado " + grupo.BorrarPorNombre(nombre) + " dinosaurios");
                    Console.ReadLine();
                    break;
                case "4":
                    grupo.MostrarTodos();
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine("Introduce el nombre del dinosaurio a mostrar");
                    nombre = Console.ReadLine();
                    grupo.MostrarPorNombre(nombre);
                    Console.ReadLine();
                    break;
                case "6":
                    Console.WriteLine("Introduce los datos del dinosaurio a mostrar");
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Peso: ");
                    while (!int.TryParse(Console.ReadLine(), out peso))
                    {
                        Console.WriteLine("Dato incorrecto");
                    }
                    Console.Write("Longitud: ");
                    while (!float.TryParse(Console.ReadLine(), out longitud))
                    {
                        Console.WriteLine("Dato incorrecto");
                    }
                    grupo.MostrarPorDatos(nombre, peso ,longitud);
                    Console.ReadLine();
                    break;
                case "7":
                    int orden;

                    Console.WriteLine("Como quieres que se ordenen los dinosaurios? ");
                    Console.WriteLine("1 - Por Nombre.");
                    Console.WriteLine("2 - Por Peso.");
                    Console.WriteLine("3 - Por Longitud.");
                    while (!int.TryParse(Console.ReadLine(), out orden))
                    {
                        Console.WriteLine("Dato incorrecto");
                    }
                    grupo.OrdenarDinosaurios(orden);
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }while (op != "0");
    }
}
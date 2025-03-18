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
                    grupo.AnyadirDinosaurio();
                    break;
                case "2":
                    grupo.BorrarTodos();
                    break;
                case "3":
                    Console.WriteLine("Introduce el nombre del dinosaurio a eliminar");
                    string nombre = Console.ReadLine();
                    grupo.BorrarPorNombre(nombre);
                    break;
                case "4":
                    grupo.MostrarTodos();
                    break;
                case "5":
                    Console.WriteLine("Introduce el nombre del dinosaurio a mostrar");
                    nombre = Console.ReadLine();
                    grupo.MostrarPorNombre(nombre);
                    break;
                case "6":
                    Console.WriteLine("Introduce los datos del dinosaurio a mostrar");
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Peso: ");
                    int peso = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Longitud: ");
                    float longitud = Convert.ToInt64(Console.ReadLine());
                    grupo.MostrarPorDatos(nombre, peso ,longitud);
                    break;
                case "7":
                    grupo.OrdenarDinosaurios();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }while (op != "0");
    }
}
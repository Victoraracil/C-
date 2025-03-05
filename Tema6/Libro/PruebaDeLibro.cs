using System;
class PruebaDeLibro
{
    public static void Main()
    {
        BloqueDeLibros biblioteca = new BloqueDeLibros();
        string op;
        do
        {
            Console.Clear();
            Console.WriteLine("Menú de la biblioteca");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("1 - Añadir libro");
            Console.WriteLine("2 - Ver libros");
            Console.WriteLine("3 - Buscar libro");
            Console.WriteLine("4 - Modificar libro");
            Console.WriteLine("5 - Borrar libro");
            Console.WriteLine("6 - Ordenar libros");

            op = Console.ReadLine();

            switch (op)
            {
                case "0": break;
                case "1": biblioteca.AnyadirLibro(); break;
                case "2": biblioteca.VerLibros(); break;
                case "3": biblioteca.BuscarLibro(); break;
                case "4": biblioteca.ModificarLibro(); break;
                case "5": biblioteca.BorrarLibro(); break;
                case "6": biblioteca.OrdenarLibros(); break;

                default: Console.WriteLine("Opción incorrecta"); break;
            }
        } while (op != "0");
    }
}




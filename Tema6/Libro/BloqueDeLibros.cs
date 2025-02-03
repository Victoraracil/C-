using System;
class BloqueDeLibros
{
    Documento[] libros = new Documento[1000];
    protected string autor;
    protected string titulo;
    protected string ubicacion;
    protected int paginas;
    protected string procedencia;    
    public void AñadirLibro()
    {
        for (int i = 0; i < libros.Length; i++)
        {
            if (libros[i] == null)
            {
                Console.WriteLine("Quieres añadir un libro o un documento?");
                Console.WriteLine("1 - Libro");
                Console.WriteLine("2 - Articulo");
                string opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    Console.WriteLine("Introduce el titulo de tu libro:");
                    titulo = Console.ReadLine();
                    Console.WriteLine("Introduce el autor de tu libro:");
                    autor = Console.ReadLine();
                    Console.WriteLine("Introduce la ubicacion de tu libro:");
                    ubicacion = Console.ReadLine();
                    Console.WriteLine("Introduce el numero de paginas de tu libro:");
                    paginas = Convert.ToInt32(Console.ReadLine());
                    procedencia = "Unknown";

                    libros[i] = new Libro(titulo, autor, ubicacion, paginas, procedencia);
                    break;
                }
                if (opcion == "2")
                {
                    Console.WriteLine("Introduce el titulo de tu articulo:");
                    titulo = Console.ReadLine();
                    Console.WriteLine("Introduce el autor de tu articulo:");
                    autor = Console.ReadLine();
                    Console.WriteLine("Introduce la ubicacion de tu articulo:");
                    ubicacion = Console.ReadLine();
                    paginas = 10;
                    Console.WriteLine("Introduce la procedencia de tu articulo:");
                    procedencia = Console.ReadLine();
                    libros[i] = new Articulo(titulo, autor, ubicacion, paginas, procedencia);
                    break;
                }
            }
        }
    }
    public void VerLibros()
    {
        for (int i = 0; i < libros.Length; i++)
        {
            if (libros[i] != null)
            {
                Console.WriteLine("Documento " + (i + 1));
                libros[i].MostrarDocumento();
                Console.WriteLine();
            }
        }
        Console.ReadLine();
    }
    public void BuscarLibro()
    {
        Console.WriteLine("Introduce el texto a buscar:");
        string texto = Console.ReadLine();
        for (int i = 0; i < libros.Length; i++)
        {
            if (libros[i] != null)
            {
                if (libros[i].Contiene(texto))
                {
                    Console.WriteLine("Documento " + (i + 1));
                    libros[i].MostrarDocumento();
                    Console.WriteLine();
                }
            }
        }
        Console.ReadLine();
    }
    public void ModificarLibro()
    {
        Console.WriteLine("Introduce el numero de documento a modificar:");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el nuevo titulo:");
        titulo = Console.ReadLine();
        Console.WriteLine("Introduce el nuevo autor:");
        autor = Console.ReadLine();
        Console.WriteLine("Introduce la nueva ubicacion:");
        ubicacion = Console.ReadLine();
        Console.WriteLine("Introduce el nuevo numero de paginas:");
        paginas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce la nueva procedencia:");
        procedencia = Console.ReadLine();
        libros[numero - 1] = new Libro(titulo, autor, ubicacion, paginas, procedencia);
    }
    public void BorrarLibro()
    {
        Console.WriteLine("Introduce el numero de documento a borrar:");
        int numero = Convert.ToInt32(Console.ReadLine());
        libros[numero - 1] = null;
    }
    public void OrdenarLibros()
    {
        Documento aux;
        for (int i = 0; i < libros.Length; i++)
        {
            for (int j = 0; j < libros.Length - 1; j++)
            {
                if (libros[j] != null && libros[j + 1] != null)
                {
                    if (libros[j].titulo.CompareTo(libros[j + 1].titulo) > 0)
                    {
                        aux = libros[j];
                        libros[j] = libros[j + 1];
                        libros[j + 1] = aux;
                    }
                }
            }
        }
    }
}
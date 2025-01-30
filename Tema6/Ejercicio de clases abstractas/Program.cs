class Program
{
    static void Main(string[] args)
    {
        DVD dvd = new DVD("DVD", 5, 3, "SONY", "PlayStation");
        Libro libro = new Libro("Libro", 10, 5, "SUN TZU" , "PlanetaDeAgostini");
        
        Console.WriteLine(dvd.ImprimirDatos());
        Console.WriteLine(libro.ImprimirDatos());
    }
}
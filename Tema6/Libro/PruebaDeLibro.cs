using System;
/*Amplía el proyecto del ejercicio 6.3.3 (Libro): crea una clase "Documento",
de la que Libro heredará todos sus atributos y métodos. Ahora la clase Libro
contendrá sólo un atributo "paginas", número entero, con sus correspondientes
Get y Set.*/
class PruebaDeLibro
{
    public static void Main()
    {
        Documento d = new Documento();
        d.SetDocumento("Los Juegos del Hambre", "Suzanne Collins", "EEUU");
        d.GetDocumento();
        Console.WriteLine();
        Libro l = new Libro();
        l.SetPaginas();
        l.GetPaginas();
    }
}

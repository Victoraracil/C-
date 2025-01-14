using System;
/*Amplía el proyecto del ejercicio 6.3.3 (Libro): crea una clase "Documento",
de la que Libro heredará todos sus atributos y métodos. Ahora la clase Libro
contendrá sólo un atributo "paginas", número entero, con sus correspondientes
Get y Set.*/

class Libro : Documento
{
    int paginas;

    public void SetPaginas()
    {
        paginas = 200;
    }
    public void GetPaginas()
    {
        Console.WriteLine(paginas + " paginas");
    }
}


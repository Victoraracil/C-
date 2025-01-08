using System;
/*Crea un proyecto a partir de la clase Libro (ejercicio 6.2.3). El "Main" pasará
a una segunda clase llamada "PruebaDeLibro" y desaparecerá de la clase Libro.*/

class Libro
{
    string autor;
    string titulo;
    string ubicacion;
    public void GetLibro()
    {
        Console.WriteLine(titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Ubicacion: " + ubicacion);

    }
    public void SetLibro(string titulo, string autor, string ubicacion)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.ubicacion = ubicacion;
    }
}

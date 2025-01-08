using System;
/*Crea un proyecto a partir de la clase Libro (ejercicio 6.2.3). El "Main" pasará
a una segunda clase llamada "PruebaDeLibro" y desaparecerá de la clase Libro.*/
class PruebaDeLibro
{
    public static void Main()
    {
        Libro l = new Libro();
        l.SetLibro("Los Juegos del Hambre", "Suzanne Collins", "EEUU");
        l.GetLibro();
    }
}

using System;
using System.Collections.Generic;
using System.IO;
/*(8.1.3) Amplia el proyecto Libro (ejercicio 6.17.8), de modo que todos los datos se
vuelquen a un fichero de texto al terminar la ejecución del programa.
Nuevamente, tú decides el formato que emplearás.*/

class Program
{
    static void Main(string[] args)
    {
        List<Libro> libros = new List<Libro>();
        string filePath = "libros.txt";
        // Simulación de añadir libros a la lista
        libros.Add(new Libro("Cien años de soledad", "Gabriel García Márquez", 1967));
        libros.Add(new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 1605));
        libros.Add(new Libro("El amor en los tiempos del cólera", "Gabriel García Márquez", 1985));
        // Guardar los datos en un fichero de texto
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var libro in libros)
            {
                writer.WriteLine(libro.ToString());
            }
        }
        Console.WriteLine($"Los datos se han guardado en {filePath}");
    }

}
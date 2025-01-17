using System;
/*A partir de las clases del ejercicio 6.6.1, añade a la clase "Persona" un nuevo
método Saludar, que reciba un parámetro, que será el texto que debe decir esa
persona cuando salude*/

class Persona
{
    protected string nombre;

    public Persona()
    {

    }
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public void Saludar(string texto)
    {
        Console.WriteLine(texto);

    }
}

using System;
/*A partir de las clases del ejercicio 6.6.1, añade a la clase "Persona" un nuevo
método Saludar, que reciba un parámetro, que será el texto que debe decir esa
persona cuando salude*/
class PersonaItaliana : Persona
{
    protected string nombre;  
    public void SaludoItaliano(string nombre)
    {
        this.nombre = nombre;
        Console.WriteLine("Ciao " + nombre);
    }

}

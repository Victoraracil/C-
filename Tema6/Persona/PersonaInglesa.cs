using System;
/*A partir de las clases del ejercicio 6.6.1, añade a la clase "Persona" un nuevo
método Saludar, que reciba un parámetro, que será el texto que debe decir esa
persona cuando salude*/

class PersonaInglesa : Persona
{
   
    public void TomarTe()
    {
        Console.WriteLine("Estoy tomando té");
    }

    public void SaludoIngles(string nombre)
    {
        this.nombre = nombre;
        Console.WriteLine("Hi, I am " + nombre);
    }
}
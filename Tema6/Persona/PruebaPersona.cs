using System;
/*A partir de las clases del ejercicio 6.6.1, añade a la clase "Persona" un nuevo
método Saludar, que reciba un parámetro, que será el texto que debe decir esa
persona cuando salude*/
class PruebaPersona
{
    static void Main()
    {
        Persona p = new Persona();
        PersonaItaliana p2 = new PersonaItaliana();
        PersonaInglesa p3 = new PersonaInglesa();
        PersonaInglesa p4 = new PersonaInglesa();

        Console.WriteLine("Escibe el nombre de la persona española:");
        p.nombre = Console.ReadLine();
        p.Saludar(p.nombre);
      
        Console.WriteLine();

        Console.WriteLine("Escibe el nombre de la persona italiana:");
        p2.nombre = Console.ReadLine();
        p2.SaludoItaliano(p2.nombre);

        Console.WriteLine();

        Console.WriteLine("Escibe el nombre de la persona inglesa:");
        p3.nombre = Console.ReadLine();
        p3.SaludoIngles(p3.nombre);
        p3.TomarTe();

        Console.WriteLine();

        p4.nombre = Console.ReadLine();
        p4.SaludoIngles(p4.nombre);
        p4.TomarTe();
    }
}

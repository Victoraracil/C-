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
        Console.WriteLine("Escibe el nombre de la persona inglesa:");
        string nombre = Console.ReadLine();
        PersonaInglesa p4 = new PersonaInglesa(nombre);
        
        
        p.SetNombre("Pepe");
        p.Saludar("Hola, soy Pepe");
      
        Console.WriteLine();

        p2.SetNombre("Musolini");
        p2.SaludoItaliano("Musolini");

        Console.WriteLine();

        p3.SetNombre("John");
        p3.SaludoIngles("John");
        p3.TomarTe();

        Console.WriteLine();

        p4.SetNombre(nombre);
        p4.SaludoIngles(nombre);
        p4.TomarTe();
    }
}

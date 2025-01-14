using System;
    /*Crea una variante ampliada del ejercicio 6.3.2. En ella, la clase Persona no
    cambia. Se creará una nueva clase PersonaInglesa, en el fichero
    "personaInglesa.cs". Esta clase deberá heredar las características de la clase
    "Persona", y añadir un método "TomarTe", de tipo void, que escribirá en pantalla
    "Estoy tomando té". Crea también una clase llamada PruebaPersona2, en el
    fichero "pruebaPersona2.cs". Esta clase deberá contener sólo la función Main, que
    creará dos objetos de tipo Persona y uno de tipo PersonaInglesa, les asignará un
    nombre, les pedirá que saluden y pedirá a la persona inglesa que tome té.*/
class PruebaPersona
{
    static void Main()
    {
        Persona p = new Persona();
        p.SetNombre("Pepe");
        p.Saludar();
        Console.WriteLine();
        Persona p2 = new Persona();
        p2.SetNombre("Juan");
        p2.Saludar();
        Console.WriteLine();
        PersonaInglesa p3 = new PersonaInglesa();
        p3.SetNombre("John");
        p3.Saludar();
        p3.TomarTe();
    }
}

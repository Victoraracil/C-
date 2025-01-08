using System;
    /*Crea un proyecto a partir de la clase Persona (ejercicio 6.2.1), para dividirlo
    en dos ficheros: la clase Persona estará en el fichero "persona.cs". Una clase
    PruebaPersona se encontrará en el fichero "pruebaPersona.cs", y deberá contener
    sólo la función Main, que creará dos objetos de tipo Persona, les asignará un
    nombre y les pedirá que saluden.*/
class PruebaPersona
{
    static void Main()
    {
        Persona p = new Persona();
        p.SetNombre("pepe");
        Persona p2 = new Persona();
        p2.SetNombre("juan");
        p.Saludar();
        p2.Saludar();
    }
}

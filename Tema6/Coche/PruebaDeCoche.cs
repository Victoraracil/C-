using System;

/*Crea un proyecto a partir de la clase Coche (ejercicio 6.2.4): además de la
clase Coche, existirá una clase PruebaDeCoche, que contendrá la función "Main",
que creará un objeto de tipo coche, pedirá al usuario su marca, modelo, cilindrada
y potencia, y luego mostrará en pantalla el valor de esos datos*/

class PruebaDeCoche
{
    public static void Main()
    {
        Coche c = new Coche();
        Console.WriteLine("Introduce la marca del choche:");
        c.SetMarca();
        Console.WriteLine("Introduce lel modelo del choche:");
        c.SetModelo();
        Console.WriteLine("Introduce la cilindrada del choche:");
        c.SetCilindrada();
        Console.WriteLine("Introduce la potencia del choche:");
        c.SetPotencia();
        Console.WriteLine();
        c.GetMarca();
        c.GetModelo();
        c.GetCilindrada();
        c.GetPotencia();
    }
}

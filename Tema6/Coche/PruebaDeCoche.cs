using System;

/*Crea dos nuevos métodos en la clase Vehiculo (ejercicio 6.6.4): uno llamado
Circular, que fijará su "velocidad" (un nuevo atributo) a 50, y otro Circular(v), que
fijará su velocidad al valor que se indique como parámetro.*/

class PruebaDeCoche
{
    public static void Main()
    {
        int v = 0;

        Coche c = new Coche();
        Console.WriteLine("Introduce la marca del choche:");
        c.SetMarca();
        Console.WriteLine("Introduce el modelo del choche:");
        c.SetModelo();
        Console.WriteLine("Introduce la cilindrada del choche:");
        c.SetCilindrada();
        Console.WriteLine("Introduce la potencia del choche:");
        c.SetPotencia();
        Console.WriteLine("Quieres establecer una velocidad personalizada a tu coche (S/N)");
        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();
        if (tecla.Key == ConsoleKey.S )
        {
            Console.WriteLine("Introduce la velocidad del coche");
            v = Convert.ToInt32(Console.ReadLine());
            c.Circular(v);
        }
        else
        {
            v = 50;
            c.Circular();
        }
        
        Console.WriteLine();
        c.MostrarDatos(v);
    }
}

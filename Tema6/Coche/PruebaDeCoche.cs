using System;

/*Crea una versión alternativa de las clases Vehiculo, Coche, Moto (6.7.4), que
te avise del momento en que se entra a cada constructor. Crea un programa de
prueba que defina un coche y una moto, y comprueba su funcionamiento.*/

class PruebaDeCoche
{
    public static void Main()
    {
        int v = 0;

        Coche c = new Coche();
        c.MostrarDatos(v);
        Console.WriteLine();
        
        Moto moto = new Moto();
        moto.MostrarDatos(v);
        /*Console.WriteLine("Introduce la marca del choche:");
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
        }*/

       
    }
}

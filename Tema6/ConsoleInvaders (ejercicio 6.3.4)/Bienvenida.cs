using System;

class Bienvanida
{
    bool salir;
    public void LanzarBienvenida()
    {
        ConsoleKeyInfo tecla;
        Console.WriteLine("Bienvenido a Console Invaders. Pulse ENTER para jugar o ESC para salir");
        do
        {
            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Escape)
            {
                salir = true;
            }
            if (tecla.Key == ConsoleKey.Enter)
            {
                salir = false;
            }

        } while (tecla.Key != ConsoleKey.Escape && tecla.Key != ConsoleKey.Enter);

    }
    public bool GetSalir()
    {
        return this.salir;
    }

}

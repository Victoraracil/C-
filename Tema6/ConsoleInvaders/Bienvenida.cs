using System;

/*
 * Clase para la pantalla de bienvenida del juego
 */
class Bienvenida
{
    private bool salir;

    // Lanza la pantalla de bienvenida, y se guarda si 
    // queremos salir o jugar en la variable "salir"
    public void LanzarBienvenida()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        for (int i = 0; i < 5; i++)
            Console.WriteLine();
        Console.WriteLine("------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bienvenido a Console Invaders.");
        Console.WriteLine("Pulse ENTER para jugar o Esc para salir");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("------------------------------------------");

        Console.ResetColor();

        ConsoleKeyInfo tecla = Console.ReadKey(true);
        if (tecla.Key == ConsoleKey.Escape)
        {
            salir = true;
            Environment.Exit(0);
        }
        else if (tecla.Key == ConsoleKey.Enter)
        {
            salir = false;
            Console.Clear();    
        }
        else
        {
            Console.WriteLine("Opción incorrecta. Saliendo del juego");
            salir = true;
        }
    }
       
    // Obtiene si queremos salir del juego
    public bool GetSalir()
    {
        return salir;
    }
}
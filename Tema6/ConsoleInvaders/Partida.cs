using System;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*Amplía el esqueleto del ConsoleInvaders (6.11.3), para que haya tres tipos
de enemigos, y un array que contenga 3x10 enemigos (3 filas, cada una con 10
enemigos de un mismo tipo, pero distinto del tipo de los elementos de las otras
filas). Cada tipo de enemigos será una subclase de Enemigo, que se distinguirá por
usar una "imagen" diferente. Puedes usar la "imagen" que quieras (siempre que
sea un string de letras, como "}{" o "XX"). Si estas imágenes no se muestran
correctamente en pantalla al lanzar una partida (que es posible, según el
planteamiento que elijas), no te preocupes por ahora, lo solucionaremos en el
siguiente apartado*/
class Partida
{
    int x = 1;
    public void LanzarPartida()
    {
        ConsoleKeyInfo tecla = new ConsoleKeyInfo();
        Console.SetWindowSize(120, 29);
        Nave nave = new Nave(60, 28, @"/!\", ConsoleColor.White);
        Ovni ovni = new Ovni(1, 1, "(_____)",ConsoleColor.Cyan);
        BloqueEnemigos enemigos = new BloqueEnemigos();
        TorreDefensiva torreDefensiva = new TorreDefensiva(60, 28);
        TorreDefensiva[] torreDefensivas = new TorreDefensiva[4];
       

        do
        {
            DibujarElementos(nave, enemigos, torreDefensiva, ovni);
            Thread.Sleep(Parametros.PAUSA_BUCLE);
            tecla = Console.ReadKey(true);
            if (Console.KeyAvailable)
            {
                while (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey(true);
                }
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    nave.MoverA(nave.GetX() - 1, nave.GetY());
                }
                else if (tecla.Key == ConsoleKey.RightArrow)
                {
                    nave.MoverA(nave.GetX() + 1, nave.GetY());
                }
                else if (tecla.Key == ConsoleKey.Spacebar)
                {
                    nave.Disparar();
                }
            }
            enemigos.Mover();
            enemigos.IntentarDisparo();
            enemigos.MoverDisparo();
            nave.MoverDisparo();
            enemigos.ComprobarColisionConNave(nave);
            enemigos.ComprobarColisionConTorres(torre);
            Actualizaciones(nave);
        }
        while (tecla.Key != ConsoleKey.Escape);
    }
    public void Actualizaciones(Nave nave)
    {
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Puntos: {0}", nave.GetPuntos());

        Console.SetCursorPosition(Parametros.ANCHO - 10, 0);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Vidas: {0}", nave.GetVidas());

        Console.ResetColor();
    }
    public void DibujarElementos(Nave nave, BloqueEnemigos enemigos, TorreDefensiva torreDefensiva, Ovni ovni)
    {
        nave.Dibujar();
        enemigos.Dibujar();
        torreDefensiva.Dibujar();
        ovni.Dibujar();

    }
}
using System;
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

        Console.SetWindowSize(120, 29);
        Nave nave = new Nave(60, 28, @"/!\", ConsoleColor.White);
        BloqueEnemigos bloqueEnemigos = new BloqueEnemigos();
        DisparoAmigo disparoAmigo = new DisparoAmigo(nave.x + 1, nave.y + 1, "|", ConsoleColor.White);    
        DibujarElementos(nave, bloqueEnemigos);

        do //bucle principal del juego
        {
            Thread.Sleep(100);
            bloqueEnemigos.MoverBloque();
            DibujarElementos(nave, bloqueEnemigos);
            ComprobarTeclas(nave);
            ComprobarColisiones(nave, bloqueEnemigos);
        } while (x == 1);
    }

    public void ComprobarTeclas(Nave nave)
    {
        ConsoleKeyInfo tecla;


        if (Console.KeyAvailable)
        {
            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.LeftArrow)
            {
                nave.MoverDerecha();
                nave.Dibujar();
            }
            if (tecla.Key == ConsoleKey.RightArrow)
            {
                nave.MoverIzquierda();
                nave.Dibujar();
            }
            if (tecla.Key == ConsoleKey.Spacebar)
            {
                nave.Disparar();
            }
        }       
    }
    public void ComprobarColisiones(Nave nave, BloqueEnemigos bloqueEnemigos)
    {
        /*for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Enemigo enemigo = bloqueEnemigos.GetEnemigo(i, j);
                if (enemigo.x == nave.Disparo.x && enemigo.y == nave.Disparo.y)
                {
                    enemigo.DesactivarEnemigo();
                    nave.Disparo.Desactivar();
                }
            }
        }*/
    }
    public void DibujarElementos(Nave nave, BloqueEnemigos bloqueEnemigos)
    {
        nave.Dibujar();
        bloqueEnemigos.DibujarBloque();
    }
}
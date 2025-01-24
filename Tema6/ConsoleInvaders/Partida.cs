using System;
/*Amplía el esqueleto del ConsoleInvaders (6.6.3): La clase Enemigo tendrá un
segundo constructor, sin parámetros, que prefijará su posición inicial a (100,80)
para estas primeras pruebas. La clase Nave tendrá un segundo constructor, con
parámetros X e Y, para poder colocar la nave en otra posición desde Main. Verás
que hay código repetitivo en esos dos contructores, pero más adelante lo
optimizaremos.*/
class Partida
{
    int x = 1;
    public void LanzarPartida()
    {
        ConsoleKeyInfo tecla; 
        Nave nave = new Nave();
        Enemigo enemigo = new Enemigo();
        nave.Dibujar();
        enemigo.Dibujar();
        
        
        do
        {
            Console.Write("");
            tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.LeftArrow)
            {
                nave.MoverDerecha();
            }
            if (tecla.Key == ConsoleKey.RightArrow)
            {
                nave.MoverIzquierda();
            }

        } while ( x == 1);
        
    }
}
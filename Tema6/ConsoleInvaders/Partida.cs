using System;
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
    
    //Disparo disparo = new Disparo(1,1);


    public void LanzarPartida()
    {

        Console.SetWindowSize(120, 29);
        Nave nave = new Nave(60, 28, @"/!\", ConsoleColor.White);
        BloqueEnemigos bloqueEnemigos = new BloqueEnemigos();
        
        do
        {
            Thread.Sleep(100);
            ComprobarColisiones();
            DibujarElementos(nave, bloqueEnemigos);
            ComprobarTeclas(nave);
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
            }
            if (tecla.Key == ConsoleKey.RightArrow)
            {
                nave.MoverIzquierda();
            }
            if (tecla.Key == ConsoleKey.Spacebar)
            {
                //disparar
            }
        }
        

        
    }

    
    public void ComprobarColisiones()
    {

    }

    public void DibujarElementos(Nave nave, BloqueEnemigos bloqueEnemigos)
    {
        nave.Dibujar();
        bloqueEnemigos.DibujarBloque();

    }
}
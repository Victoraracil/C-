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
    Nave nave = new Nave();
    Enemigo enemigo = new Enemigo(37, 5);
    BloqueEnemigos bloqueEnemigos = new BloqueEnemigos(37, 5);
    Disparo disparo = new Disparo(40,27);


    public void LanzarPartida()
    {
        Console.SetWindowSize(120, 29);
        bloqueEnemigos.CrearBloque();
        DibujarElementos();
        ComprobarTeclas();
    }

    public void ComprobarTeclas()
    {
        ConsoleKeyInfo tecla;
        do
        {
            if (Console.KeyAvailable)
            {
                tecla = Console.ReadKey();
            }
            else
            {
                tecla = new ConsoleKeyInfo();
                MoverElementos(0);
            }
            
            if (tecla.Key == ConsoleKey.LeftArrow)
            {
               MoverElementos(1);
            }
            if (tecla.Key == ConsoleKey.RightArrow)
            {
                MoverElementos(2);
            }
            if (tecla.Key == ConsoleKey.Spacebar)
            {
                MoverElementos(4);
              
            }
        } while (x == 1);
    }

    public void MoverElementos(int i)
    {
        bloqueEnemigos.MoverBloque();

        if (i == 1)
        {
            nave.MoverDerecha();
        }
        if (i == 2)
        {
            nave.MoverIzquierda();
        }
        if (i == 4)
        {
            do
            {
                disparo.MoverArriba();
            } while (x > 0);
        }
    }
    public void ComprobarColisiones()
    {

    }

    public void DibujarElementos()
    {
        nave.Dibujar(@"/!\");
        bloqueEnemigos.DibujarBloque();


    }
}
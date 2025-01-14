using System;
class Partida
{
    public void LanzarPartida()
    {
        Nave nave = new Nave();
        nave.Dibujar();
        Enemigo enemigo = new Enemigo();
        enemigo.Dibujar();
        Console.WriteLine("");
    }
}
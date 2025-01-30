using System;

class Disparo : Sprite
{
    
    public Disparo(int x, int y)
    {
        this.x = x; this.y = y;
        imagen = "|";
    }
    public void MoverArriba()
    {
        MoverA(0, -1);
        Dibujar(imagen);
    }
    public void MoverAbajo()
    {
        MoverA(0, 1);
        Dibujar(imagen);
    }
    public void Desaparecer()
    {
        Borrar();
    }
}

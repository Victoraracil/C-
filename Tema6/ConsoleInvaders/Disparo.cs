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
        MoverA(this.x, -1);
        Dibujar(imagen);
    }
    public void MoverAbajo()
    {
        MoverA(this.x, 1);
        Dibujar(imagen);
    }
    public void Desaparecer()
    {
        Borrar();
    }
}

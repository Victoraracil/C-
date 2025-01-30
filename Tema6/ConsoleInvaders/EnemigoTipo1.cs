using System;

class EnemigoTipo1 : Enemigo
{
    public EnemigoTipo1(int x, int y) : base(x, y)
    {
        this.x = x; this.y = y;
    }
    public string imagen = "]_[";
} 

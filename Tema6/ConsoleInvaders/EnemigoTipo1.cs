using System;

class EnemigoTipo1 : Enemigo
{
    public string imagen = "]_[";

    public EnemigoTipo1(int x, int y, string imagen, ConsoleColor color) : base(x, y, imagen, color)
    {
        this.x = x; this.y = y;
    }
} 

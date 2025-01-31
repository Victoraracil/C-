using System;

class EnemigoTipo2 : Enemigo
{
    public string imagen = "].[";

    public EnemigoTipo2(int x, int y, string imagen, ConsoleColor color) : base(x, y, imagen, color)
    {
        this.x = x; this.y = y;        
    }
}

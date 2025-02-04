using System;

class EnemigoTipo1 : Enemigo
{
    public EnemigoTipo1(int x, int y, string imagen, ConsoleColor color) : base(x, y, imagen, color)
    {
        this.x = x; this.y = y;
        imagen = "]_[";
    }
    public override void Dibujar()
    {
        color = ConsoleColor.Green;
        base.Dibujar();
        Console.ResetColor();
    }
} 

using System;

class Ovni : Enemigo
{
    public Ovni(int x, int y, string imagen, ConsoleColor color) : base(x, y, imagen, color)
    {
        this.x = x; this.y = y;
        imagen = "(_____)";
    }
    public override void Dibujar()
    {
        color = ConsoleColor.Cyan;
        base.Dibujar();
        Console.ResetColor();
    }
}
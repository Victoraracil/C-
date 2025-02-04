using System;

class EnemigoTipo2 : Enemigo
{
    public EnemigoTipo2(int x, int y, string imagen, ConsoleColor color) : base(x, y, imagen, color)
    {
        this.x = x; this.y = y;
        imagen = "].[";
    }
    public override void Dibujar()
    {
        color = ConsoleColor.Yellow;
        base.Dibujar();
        Console.ResetColor();
    }
}

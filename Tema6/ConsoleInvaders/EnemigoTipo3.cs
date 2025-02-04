using System;

class EnemigoTipo3 : Enemigo
{
    public EnemigoTipo3(int x, int y, string imagen, ConsoleColor color) : base(x, y, imagen, color)
    {
        this.x = x; this.y = y;
        imagen = ")-(";
    }
    public override void Dibujar()
    {
        color = ConsoleColor.Red;
        base.Dibujar();
        Console.ResetColor();
    }
}

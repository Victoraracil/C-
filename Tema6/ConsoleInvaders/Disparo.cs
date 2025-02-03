using System;
/* una clase Disparo en ConsoleInvaders. Cuando el usuario pulse
cierta tecla (Espacio, por ejemplo), aparecerá un disparo encima de la nave, y se
moverá hacia arriba hasta que desaparezca por la parte superior de la pantalla.
Existirá un único disparo, y no se podrá volver a disparar si está activo (en
pantalla). Inicialmente estará desactivado, y lo volverá a estar cuando llegue al
margen de la pantalla.*/

class Disparo
{
    public int x = 1;
    public int y = 1;
    public string imagen = "!";
    public ConsoleColor color = ConsoleColor.White;
    public bool activo = false;
    public Disparo(int x, int y, string imagen = "!", ConsoleColor color = ConsoleColor.White)
    {
        this.x = x;
        this.y = y;
        this.imagen = imagen;
        this.color = color;
    }
    public void MoverArriba()
    {
        if (y > 0)
        {
            Borrar();
            y--;
        }
        else
        {
            DesactivarDisparo();
        }
    }
    public void Dibujar()
    {
        ConsoleColor colorAnterior = Console.ForegroundColor;
        Console.ForegroundColor = this.color;
        Console.SetCursorPosition(this.x, this.y);
        Console.Write(imagen);
        Console.ForegroundColor = colorAnterior;
    }
    public void Borrar()
    {
        Console.SetCursorPosition(this.x, this.y);
        Console.Write(new String(' ', this.imagen.Length));
    }
    public void ActivarDisparo()
    {
        activo = true;
    }
    public void DesactivarDisparo()
    {
        activo = false;
        Borrar();
    }
}
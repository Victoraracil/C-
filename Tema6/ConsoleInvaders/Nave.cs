using System;
using System.Reflection;

/*Crea una clase Disparo en ConsoleInvaders. Cuando el usuario pulse
cierta tecla (Espacio, por ejemplo), aparecerá un disparo encima de la nave, y se
moverá hacia arriba hasta que desaparezca por la parte superior de la pantalla.
Existirá un único disparo, y no se podrá volver a disparar si está activo (en
pantalla). Inicialmente estará desactivado, y lo volverá a estar cuando llegue al
margen de la pantalla.*/
internal class Nave : Sprite
{   
    public Nave(int x, int y, string imagen, ConsoleColor color) : base(x, y, imagen, color)
    {
        color = ConsoleColor.White;
    }
    public void MoverDerecha()
    {
        MoverA(-1, this.y);
    }
    public void MoverIzquierda()
    {
        MoverA(1, this.y);
    }
    public void Disparar()
    {
    
    }
}
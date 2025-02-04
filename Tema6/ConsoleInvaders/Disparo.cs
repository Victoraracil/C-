using System;
/* una clase Disparo en ConsoleInvaders. Cuando el usuario pulse
cierta tecla (Espacio, por ejemplo), aparecerá un disparo encima de la nave, y se
moverá hacia arriba hasta que desaparezca por la parte superior de la pantalla.
Existirá un único disparo, y no se podrá volver a disparar si está activo (en
pantalla). Inicialmente estará desactivado, y lo volverá a estar cuando llegue al
margen de la pantalla.*/

class Disparo : Sprite
{
    private bool activo;

    public Disparo(int x, int y) : base(x, y, "|", ConsoleColor.Yellow)
    {
        activo = false;
        imagen = "|";
    }

    // Establecer el disparo como activo o no
    public void SetActivo(bool a)
    {
        activo = a;
    }

    // Obtener si el disparo está activo o no
    public bool GetActivo()
    {
        return activo;
    }

    // Dibujar el disparo
    public override void Dibujar()
    {
        if (activo)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Dibujar();
            Console.ResetColor();
        }
    }
}
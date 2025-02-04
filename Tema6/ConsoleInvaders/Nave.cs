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
    private Disparo disparo;
    public Disparo[] disparos;

    // Vidas restantes
    private int vidas;

    // Puntos actuales
    private int puntos;
    public Nave(int x, int y, string imagen, ConsoleColor color) : base(x, y, imagen, color)
    {
        color = ConsoleColor.White;
        this.x = x;
        this.y = y;
        this.imagen = imagen;
        disparo = new Disparo();
        vidas = Parametros.VIDAS_INICIALES;
        puntos = 0;
    }
    public void MoverDerecha()
    {
        MoverA(this.x - 1, this.y);
    }
    public void MoverIzquierda()
    {
        MoverA(this.x + 1, this.y);
    }
    public void Disparar()
    {
        if (!disparo.GetActivo())
        {
            disparo.MoverA(x, y - 1);
            disparo.SetActivo(true);
        }
    }
    public void MoverDisparo()
    {
        if (disparo.GetActivo())
        {
            if (disparo.GetY() > 0)
                disparo.MoverA(disparo.GetX(), disparo.GetY() - 1);
            else
            {
                disparo.SetActivo(false);
                disparo.MoverA(x, y);
            }
        }
    }

    // Redefinición del método Dibujar
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.White;
        base.Dibujar();
        disparo.Dibujar();
        Console.ResetColor();
    }
    public int GetVidas()
    {
        return vidas;
    }

    public int GetPuntos()
    {
        return puntos;
    }

    public void SetVidas(int vidas)
    {
        this.vidas = vidas;
    }

    public void SetPuntos(int puntos)
    {
        this.puntos = puntos;
    }
}
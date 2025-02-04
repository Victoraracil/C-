using System;

/*Amplía el esqueleto del ConsoleInvaders (6.11.3), para que haya tres tipos
de enemigos, y un array que contenga 3x10 enemigos (3 filas, cada una con 10
enemigos de un mismo tipo, pero distinto del tipo de los elementos de las otras
filas). Cada tipo de enemigos será una subclase de Enemigo, que se distinguirá por
usar una "imagen" diferente. Puedes usar la "imagen" que quieras (siempre que
sea un string de letras, como "}{" o "XX"). Si estas imágenes no se muestran
correctamente en pantalla al lanzar una partida (que es posible, según el
planteamiento que elijas), no te preocupes por ahora, lo solucionaremos en el
siguiente apartado*/
internal class Enemigo : Sprite
{
    protected bool activo;
    protected int direccion;
    public Enemigo(int x, int y, string imagen, ConsoleColor color) : base(x, y, imagen, color)
    {
        activo = true;
        this.x = x;
        this.y = y;
        this.imagen = imagen;
        this.color = color;
        direccion = 1;
    }
    public bool GetActivo()
    {
        return activo;
    }
    public void SetActivo(bool activo)
    {
        this.activo = activo;
    }
    public override void Dibujar()
    {
        if (activo)
        {
            base.Dibujar();
        }
    }
    public void Mover()
    {
        if ((x < Parametros.ANCHO - imagen.Length && direccion > 0)
            || (x > 0 && direccion < 0))
        {
            // Mover a la derecha o izquierda, según la dirección
            MoverA(x + direccion, y);
        }
        else
        {
            // Cambiar la dirección de movimiento
            direccion = -direccion;
        }
    }

    public void DesactivarEnemigo()
    {
        Borrar();
        x = -1;
        y = -1;
    }
   
   

}
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
class Enemigo : Sprite
{
    public Enemigo(int x, int y)
    {
        imagen = "]-["; // ]_[ , ].[ , ]>-<[ , [_____]
    }
    public void MoverIzquierda()
    {
        MoverA(1, 0);
        Dibujar(imagen);
    }

    public void MoverDerecha()
    {
        MoverA(-1, 0);
        Dibujar(imagen);
    }   

    public void Desaparecer()
    {
        Borrar();
    }

}
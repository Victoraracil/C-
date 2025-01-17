using System;

/*Amplía el esqueleto del ConsoleInvaders (6.6.3): La clase Enemigo tendrá un
segundo constructor, sin parámetros, que prefijará su posición inicial a (100,80)
para estas primeras pruebas. La clase Nave tendrá un segundo constructor, con
parámetros X e Y, para poder colocar la nave en otra posición desde Main. Verás
que hay código repetitivo en esos dos contructores, pero más adelante lo
optimizaremos.*/
class Enemigo : Sprite
{
    public Enemigo()
    {
        x = 60; y = 5;
        imagen = "]-["; // ]_[, ].[
    }

}
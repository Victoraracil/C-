using System;

/*Amplía el esqueleto del ConsoleInvaders (ejercicio 6.5.4): La clase Nave
tendrá un constructor, sin parámetros, que prefijará su posición inicial en las
coordenadas 500,600. El constructor de la clase Enemigo recibirá como
parámetros las coordenadas X e Y iniciales, para que se puedan cambiar desde el
cuerpo del programa. La imagen de la nave y del enemigo se prefijarán en estos
constructores.*/
class Nave : Sprite
{
    public Nave()
    {
        x = 60; y = 22;
        imagen = "/!\\";
    }
    public void MoverDerecha()
    {
        MoverA("derecha");
    }
    public void MoverIzquierda()
    {
        MoverA("izquierda");
    }

}
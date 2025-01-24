using System;

/*Crea una versión alternativa del esqueleto del ConsoleInvaders (6.7.3) en la
que el constructor de Sprite escriba en pantalla "Creando sprite" y los
constructores de Nave escriba en pantalla "Creando nave en posición prefijada" o
"Creando nave en posición indicada por el usuario", según el caso (deberás hacer
una pausa para poder verlo antes de que se borre la pantalla). Comprueba su
funcionamiento.*/
class Nave : Sprite
{
    public Nave()
    {
        x = 60; y = 28;
        imagen = @"/!\";
    }
   
    public void MoverDerecha()
    {
        MoverA(-1, this.y);
    }
    public void MoverIzquierda()
    {
        MoverA(1, this.y);
    }

}
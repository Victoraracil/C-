﻿using System;

    /*Amplía el esqueleto del ConsoleInvaders (ejercicio 6.3.5): Crea una clase
    Nave, con atributos "x" e "y" (números enteros, "x" de 0 a 1023 e "y" entre 0 y 767,
    pensando en una pantalla de 1024x768), e imagen (un string formado por dos
    caracteres, como "/\"). También tendrá un método MoverA(nuevaX, nuevaY) que lo
    mueva a una nueva posición, y un método Dibujar, que muestre esa imagen en
    pantalla (como esta versión es para consola, tendrás que dividir X para que tenga
    un valor entre 0 y 79, y la Y entre 0 y 23; por ejemplo, puedes dividir la X entre 12 y
    la Y entre 30). Puedes usar Console.SetCursorPosition(x,y) para situarte en unas
    coordenadas de pantalla. Crea también clase Enemigo, con los mismos atributos.
    Su imagen podría ser "][". El método Lanzar de la clase Partida creará una nave en
    las coordenadas (500, 600) y la dibujará, creará un enemigo en las coordenadas
    (100, 80) y lo dibujará, y finalmente esperará a que el usuario pulse Intro para
    terminar la falsa sesión de juego.*/
class Nave
{
    int x = 40;
    int y = 22;
    string imagen = "/\\";

    public void MoverA()
    {
        //x++; y --;   
    }
    public void Dibujar()
    {
        Console.SetCursorPosition(this.x,  this.y);
        Console.WriteLine(imagen);


    }
}
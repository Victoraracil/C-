using System;
using System.ComponentModel;
/*Amplía el esqueleto del ConsoleInvaders (6.7.3), para que haya 10
enemigos en una misma fila (todos compartirán una misma coordenada Y, pero
tendrán distinta coordenada X). Necesitarás usar el constructor en la clase
Enemigo que recibe los parámetros X e Y.*/

class Sprite    
{
    protected int x = 40;
    protected int y = 20;
    protected string imagen = "/\\";
    protected ConsoleColor color = ConsoleColor.White;
    public Sprite(int x, int y, string imagen = "<>", ConsoleColor color = ConsoleColor.White)
    {
        this.x = x;
        this.y = y;
        this.imagen = imagen;
        this.color = color;

    }

    public void MoverA(int x1, int y1)// modificar con dos parametros
    {

        if (x + x1 >= 0 && x + this.imagen.Length + x1 <= 120)
        {
            Borrar();
            x = x + (x1);
        }
        if (y + y1 >= 0 && y + y1 <= 29)
        {
            Borrar();
            y = y + (y1);
        }
       
        else
        {
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
        Console.Write(new String(' ' ,this.imagen.Length));
    }

    
}
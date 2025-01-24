using System;
/*Crea una versión alternativa del esqueleto del ConsoleInvaders (6.7.3) en la
que el constructor de Sprite escriba en pantalla "Creando sprite" y los
constructores de Nave escriba en pantalla "Creando nave en posición prefijada" o
"Creando nave en posición indicada por el usuario", según el caso (deberás hacer
una pausa para poder verlo antes de que se borre la pantalla). Comprueba su
funcionamiento.*/

class Sprite    
{
    protected int x = 40;
    protected int y = 30;
    protected string imagen = "/\\";
    public Sprite()
    {
            
        int x = 40;
        int y = 30;
        string imagen = "/\\";
    }



    public void MoverA(int x1, int y1)// modificar con dos parametros
    {

        if (x - 1 == 0)
        {
            Borrar();
            x++;
        }
        else if (x + this.imagen.Length  == 120)
        {
            Borrar();
            x--;
        }
        else
        {
            Borrar();
            x = x + (x1);
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(imagen);
        }
       
    }
    public void Dibujar()
    {
        Console.SetCursorPosition(this.x, this.y);
        Console.WriteLine(imagen);


    }
    public void Borrar()
    {
        Console.SetCursorPosition(this.x, this.y);
        Console.Write(new String(' ' ,this.imagen.Length));
    }
}
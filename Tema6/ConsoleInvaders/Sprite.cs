using System;
using System.ComponentModel;
/*Amplía el esqueleto del ConsoleInvaders (6.7.3), para que haya 10
enemigos en una misma fila (todos compartirán una misma coordenada Y, pero
tendrán distinta coordenada X). Necesitarás usar el constructor en la clase
Enemigo que recibe los parámetros X e Y.*/

class Sprite    
{
    public int x;
    public int y;
    protected string imagen;
    protected ConsoleColor color = ConsoleColor.White;
    public Sprite(int x, int y, string imagen = "<>", ConsoleColor color = ConsoleColor.White)
    {
        this.x = x;
        this.y = y;
        this.imagen = imagen;
        this.color = color;


    }
    public int GetX()
    {
        return this.x;
    }
    public int GetY()
    {
        return this.y;
    }
    public string GetImagen()
    {
        return this.imagen;
    }
    public void SetX(int x)
    {
        this.x = x;
    }
    public void SetY(int y)
    {
        this.y = y;
    }
    public void SetImagen(string imagen)
    {
        this.imagen = imagen;
    }
    public void MoverA(int x, int y)
    {
        if (x < 0 || x >= Console.WindowWidth || y < 0 || y >= Console.WindowHeight)
        {
            return;
        }
        else
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < imagen.Length; i++)
                Console.Write(" ");
            SetX(x);
            SetY(y);
            Dibujar();
        }

        
    }
    public virtual void Dibujar()
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

    public bool ColisionaCon(Sprite s)
    {
        // Consideramos los tamaños de cada sprite para ver si colisionan 
        // horizontalmente
        int tam1 = GetImagen().Length;
        int tam2 = s.GetImagen().Length;

        // Colisionarán en horizontal si uno de los sprites está contenido entre 
        // la coordenada X y la coordenada X + el tamaño del sprite del otro
        bool colisionX = (GetX() <= s.GetX() && GetX() + tam1 >= s.GetX()) ||
                         (s.GetX() <= GetX() && s.GetX() + tam2 >= GetX());
        bool colisionY = GetY() == s.GetY();

        return colisionX && colisionY;
    }

}
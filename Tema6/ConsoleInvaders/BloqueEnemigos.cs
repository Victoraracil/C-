using System;
using System.Threading;

class BloqueEnemigos
{
    string[,] bloqueEnemigos = new string[3, 10];
    string imagen = "]-[";
    int x, y;
    bool direccionDerecha = true;
    public BloqueEnemigos(int x, int y)
    {
        this.x = x; this.y = y;
    }
    public void CrearBloque()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (i == 0)
                {
                    EnemigoTipo1 enemigo1 = new EnemigoTipo1(1,1);
                    bloqueEnemigos[i, j] = enemigo1.imagen;
                }
                if (i == 1)
                {
                    EnemigoTipo2 enemigo2 = new EnemigoTipo2(1, 1);
                    bloqueEnemigos[i, j] = enemigo2.imagen;
                }
                if (i == 2)
                {
                    EnemigoTipo3 enemigo3 = new EnemigoTipo3(1, 1);
                    bloqueEnemigos[i, j] = enemigo3.imagen;
                }
            }
        }
    }
    public void DibujarBloque()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                int xPos = x + j * 5; // Espacio horizontal entre enemigos
                int yPos = y + i * 2; // Espacio vertical entre filas de enemigos
                if (i == 0) 
                { 
                    Console.ForegroundColor = ConsoleColor.Red;     
                }
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                imagen = bloqueEnemigos[i,j];
                Console.SetCursorPosition(xPos, yPos);
                Console.Write(imagen);
            }
        }
    }
    public void MoverBloque()
    {
        Thread.Sleep(100);
        BorrarBloque();

        if (direccionDerecha == true)
        {
            if (x + 50 < 120)
            {
                x++;
            }
            else
            {
                direccionDerecha = false;
                y++;
            }
        }
        else
        {
            if (x > 0)
            {
                x--;
            }
            else
            {
                direccionDerecha = true;
                y++;
            }
        }
        DibujarBloque();
    }
    public void BorrarBloque()
    {
        imagen = "   ";
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                int xPos = x + j * 5; // Espacio horizontal entre enemigos
                int yPos = y + i * 2; // Espacio vertical entre filas de enemigos
                Console.SetCursorPosition(xPos, yPos);
                Console.Write(imagen);
                
            }
        }
    }
}

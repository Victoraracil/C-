using System;
using System.Threading;

class BloqueEnemigos
{
    Enemigo[,] bloqueEnemigos = new Enemigo[3, 10];
    int x = 0, y = 2;
    bool direccionDerecha = true;
    String imagen = ")-(";
    public BloqueEnemigos()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (i == 0)
                {
                    bloqueEnemigos[i, j] = new EnemigoTipo1(x + j * 5, y + i * 2, imagen, ConsoleColor.Red);

                }
                if (i == 1)
                {
                    bloqueEnemigos[i, j] = new EnemigoTipo2(x + j * 5, y + i * 2, imagen, ConsoleColor.Red);
                }
                if (i == 2)
                {
                    bloqueEnemigos[i, j] = new EnemigoTipo3(x + j * 5, y + i * 2, imagen, ConsoleColor.Red);

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
                if (i == 0) 
                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                    bloqueEnemigos[i, j].Dibujar();
                }
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    bloqueEnemigos[i, j].Dibujar();
                }
                if (i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    bloqueEnemigos[i, j].Dibujar();
                }
                

            }
        }
    }
    public void MoverBloque()
    {

        BorrarBloque();

        if (direccionDerecha == true)
        {
            if (x + bloqueEnemigos.Length < 120)
            {
                
            }
            else
            {
                direccionDerecha = false;
                //EnemigoTipo1.MoverA(this.x, 1);
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
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                bloqueEnemigos[i, j].Borrar();

            }
        }
    }
}

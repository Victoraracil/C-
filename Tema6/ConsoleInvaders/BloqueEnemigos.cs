using System;
using System.Threading;

class BloqueEnemigos
{
    Enemigo[,] bloqueEnemigos = new Enemigo[3, 10];
    public int x = 0, y = 2;
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
                    bloqueEnemigos[i, j] = new EnemigoTipo1(x + j * 5, y + i * 2, "]_[", ConsoleColor.Red);

                }
                if (i == 1)
                {
                    bloqueEnemigos[i, j] = new EnemigoTipo2(x + j * 5, y + i * 2, "].[", ConsoleColor.Yellow);
                }
                if (i == 2)
                {
                    bloqueEnemigos[i, j] = new EnemigoTipo3(x + j * 5, y + i * 2, ")-(", ConsoleColor.Green);

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
            if (x + 49 < 120)
            {              
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        bloqueEnemigos[i, j].MoverA(1, 0);
                        
                    }
                }
                x++;
            }
            else
            {
                direccionDerecha = false;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        bloqueEnemigos[i, j].MoverA(0, 1);
                    }
                }
            }
        }
        else
        {
            if (x  > 0)
            {             
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        bloqueEnemigos[i, j].MoverA(-1, 0);
                    }
                }
                x--;
            }
            else
            {
                direccionDerecha = true;              
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        bloqueEnemigos[i, j].MoverA(0, 1);
                    }
                }
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
    public Enemigo GetEnemigo(int i, int j)
    {
        return bloqueEnemigos[i, j];
    }
    public void DesactivarEnemigo() 
    {
        
    }
}

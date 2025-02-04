using System;
using System.Drawing;
using System.Threading;

class BloqueEnemigos
{   
    private Enemigo[,] enemigos;
    private int direccion;
    private Disparo disparo;
    public BloqueEnemigos()
    {
        enemigos = new Enemigo[3, 10];
        disparo = new Disparo();
        for (int i = 0; i < enemigos.GetLength(0); i++)
        {
            for (int j = 0; j < enemigos.GetLength(1); j++)
            {
                // Creamos 3 filas de enemigos, en cada una de un tipo diferente
                if (i == 0)
                    enemigos[i, j] = new EnemigoTipo1(j * Parametros.SEPARACION_ENEMIGOS, 5, "]_[", ConsoleColor.Red);
                else if (i == 1)
                    enemigos[i, j] = new EnemigoTipo2(j * Parametros.SEPARACION_ENEMIGOS, 7, "]_[", ConsoleColor.Yellow);
                else
                    enemigos[i, j] = new EnemigoTipo3(j * Parametros.SEPARACION_ENEMIGOS, 9, "]_[", ConsoleColor.Green);
            }
        }

        direccion = 1;
    }

    // Obtiene el enemigo con una X más a la izquierda que el resto
    private Enemigo GetEnemigoIzquierdo()
    {
        Enemigo elegido = null;
        int minX = Parametros.ANCHO;

        for (int i = 0; i < enemigos.GetLength(0); i++)
            for (int j = 0; j < enemigos.GetLength(1); j++)
            {
                if (enemigos[i, j].GetX() < minX && enemigos[i, j].GetActivo())
                {
                    minX = enemigos[i, j].GetX();
                    elegido = enemigos[i, j];
                }
            }
        return elegido;
    }

    // Obtiene el enemigo con una X más a la derecha que el resto
    private Enemigo GetEnemigoDerecho()
    {
        Enemigo elegido = null;
        int maxX = -1;

        for (int i = 0; i < enemigos.GetLength(0); i++)
            for (int j = 0; j < enemigos.GetLength(1); j++)
            {
                if (enemigos[i, j].GetX() > maxX && enemigos[i, j].GetActivo())
                {
                    maxX = enemigos[i, j].GetX();
                    elegido = enemigos[i, j];
                }
            }
        return elegido;
    }

    // Mover el bloque de enemigos
    public void Mover()
    {
        Enemigo referencia;
        // Cogemos el enemigo más a la derecha o a la izquierda, dependiendo de 
        // la dirección de movimiento actual
        if (direccion > 0)
            referencia = GetEnemigoDerecho();
        else
            referencia = GetEnemigoIzquierdo();

        // Intentamos mover en la dirección actual si se puede. Si no, cambiamos 
        // la dirección de movimiento
        if ((referencia.GetX() < Parametros.ANCHO-
             referencia.GetImagen().Length && direccion > 0) ||
            (referencia.GetX() > 0 && direccion < 0))
        {
            // Mover a la derecha o izquierda, según la dirección
            for (int i = 0; i < enemigos.GetLength(0); i++)
                for (int j = 0; j < enemigos.GetLength(1); j++)
                {
                    enemigos[i, j].MoverA(enemigos[i, j].GetX() + direccion,
                        enemigos[i, j].GetY());
                }
        }
        else
        {
            // Cambiar la dirección de movimiento
            direccion = -direccion;
        }
    }

    // Dibujar el bloque de enemigos
    public void Dibujar()
    {
        for (int i = 0; i < enemigos.GetLength(0); i++)
            for (int j = 0; j < enemigos.GetLength(1); j++)
                enemigos[i, j].Dibujar();

        disparo.Dibujar();
    }
    public void IntentarDisparo()
    {
        int j;

        if (!disparo.GetActivo())
        {
            // Recorremos los enemigos activos, y a cada uno le damos el 10% 
            // de probabilidades de generar un disparo
            for (int i = 0; i < enemigos.GetLength(0); i++)
            {
                j = 0;
                while (j < enemigos.GetLength(1) && !disparo.GetActivo())
                {
                    if (enemigos[i, j].GetActivo())
                    {
                        int num = Parametros.random.Next(0, 10);
                        if (num >= 9)
                        {
                            disparo.MoverA(enemigos[i, j].GetX(),
                                enemigos[i, j].GetY() + 1);
                            disparo.SetActivo(true);
                        }
                    }
                    j++;
                }
            }
        }
    }

    // Mueve el disparo hacia abajo
    public void MoverDisparo()
    {
        if (disparo.GetActivo())
        {
            if (disparo.GetY() < Parametros.ALTO - 1)
                disparo.MoverA(disparo.GetX(), disparo.GetY() + 1);
            else
            {
                disparo.SetActivo(false);
                disparo.MoverA(0, 0);
            }
        }
    }
    public void ComprobarColisionConNave(Nave nave)
    {
        int j = 0;
        bool colision = false;
        while (j < nave.disparos.Length && !colision)
        {
            if (nave.disparos[j].GetActivo() && nave.ColisionaCon(nave.disparos[j]))
            {
                nave.disparos[j].SetActivo(false);
                nave.disparos[j].MoverA(0, 0);
                nave.SetVidas(nave.GetVidas() - 1);
                nave.MoverA(Parametros.ANCHO / 2,
                    Parametros.ALTO - 5);
                colision = true;
            }
            j++;
        }

        if (colision)
        {
            LimpiarDisparos(nave.disparos);
        }
    }

    // Quita los disparos activos cuando la nave ha sido alcanzada
    public void LimpiarDisparos(Disparo[] disparos)
    {
        foreach (Disparo d in disparos)
        {
            d.SetActivo(false);
            d.MoverA(0, 0);
        }
    }
    public void ComprobarColisionConTorres(TorreDefensiva[] torres, Disparo[] disparos)
    {
        foreach (TorreDefensiva t in torres)
        {
            foreach (Disparo d in disparos)
            {
                if (d.GetActivo() && t.ColisionaCon(d))
                {
                    d.SetActivo(false);
                    d.MoverA(0, 0);
                }
            }
        }
    }
}

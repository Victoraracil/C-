using System;
using System.Drawing;
using System.Text;
class TorreDefensiva : Sprite
{

    private StringBuilder[] ladrillos = {
        new StringBuilder(new String('*', Parametros.ANCHO_TORRE)),
        new StringBuilder(new String('*', Parametros.ANCHO_TORRE)),
        new StringBuilder(new String('*', Parametros.ANCHO_TORRE))
    };

    public TorreDefensiva(int x, int y, StringBuilder[] ladrillos, ConsoleColor.color)
    {
        this.x = x;
        this.y = y;
    }

   
    public override void Dibujar()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        for (int i = 0; i < ladrillos.Length; i++)
        {
            Console.SetCursorPosition(x, y + i);
            Console.Write(ladrillos[i]);
        }
        Console.ResetColor();

    }
    public void DibujarTorres()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        for (int j = 0; j < 4; j++)
        {
            for (int i = 0; i < ladrillos.Length; i++)
            {
                Console.SetCursorPosition(Parametros.ANCHO_TORRE * j, y + i);
                Console.Write(ladrillos[i]);
            }
        }
    }
    public bool ColisionaCon(Disparo d)
    {
        // Miramos si la X del disparo está dentro de la anchura de la torre
        bool colisionaX = d.GetX() >= x && d.GetX() < x + ladrillos[0].Length;
        // Miramos si la Y del disparo está dentro de la altura de la torre
        bool colisionaY = d.GetY() >= y && d.GetY() < y + ladrillos.Length;

        if (colisionaX && colisionaY)
        {
            // Miramos si hay un ladrillo (asterisco) en la posición del disparo
            // Si es así, lo borramos porque ha impactado
            bool hayLadrillo = ladrillos[d.GetY() - y][d.GetX() - x] == '*';
            if (hayLadrillo)
            {
                ladrillos[d.GetY() - y][d.GetX() - x] = ' ';
                return true;
            }
        }
        return false;
    }
}

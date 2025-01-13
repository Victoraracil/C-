using System;
/*Amplía el esqueleto del ConsoleInvaders (ejercicio 6.2.2): crea un proyecto
para Visual Studio o SharpDevelop. Además de la clase "Juego", crea una clase
"Bienvenida" y una clase "Partida". El método "Lanzar" de la clase Juego ya no
escribirá nada en pantalla, sino que creará un objeto de la clase "Bienvenida" y lo
lanzará y luego creará un objeto de la clase "Partida" y lo lanzará. El método
Lanzar de la clase Bienvenida escribirá en pantalla "Bienvenido a Console Invaders.
Pulse Intro para jugar". El método Lanzar de la clase Partida escribirá en pantalla
"Ésta sería la pantalla de juego. Pulse Intro para salir" y se detendrá hasta que el
usuario pulse Intro.

Amplía el esqueleto del ConsoleInvaders (ejercicio 6.3.4): El método Lanzar
de la clase Bienvenida escribirá en pantalla "Bienvenido a Console Invaders. Pulse
Intro para jugar o ESC para salir". Como veremos con detalle más adelante, puedes
comprobar si se pulsa ESC con "ConsoleKeyInfo tecla = Console.ReadKey(); if
(tecla.Key == ConsoleKey.Escape) salir = true;". El código de la tecla Intro es
"ConsoleKey.Enter". También puedes usar "Console.Clear();" para borrar la
pantalla. Añade un método "GetSalir" a la clase Bienvenida, que devuelva "true" si
el usuario ha escogido Salir o "false" si ha elegido Jugar. El método Lanzar de la
clase Juego repetirá la secuencia Bienvenida-Partida hasta que el usuario escoja
Salir.

Amplía el esqueleto del ConsoleInvaders (ejercicio 6.3.5): Crea una clase
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
class Juego
{
    public void Lanzar()
    {
        Bienvanida b = new Bienvanida();
        b.LanzarBienvenida();
        do
        {
            if (b.GetSalir() == false)
            {
                Partida p = new Partida();
                p.LanzarPartida();
            }
        }while (b.GetSalir() == true);        
    }
}

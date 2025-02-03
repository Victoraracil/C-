using System;
/*Amplía el esqueleto del ConsoleInvaders (ejercicio 6.4.4): Amplía la clase
Nave con un método "MoverDerecha", que aumente su X en 10 unidades, y un
"MoverIzquierda", que disminuya su X en 10 unidades. Necesitarás hacer que esos
atributos sean "protected" en la clase Sprite. El método "Lanzar" de la clase Partida
no esperará hasta el usuario pulse Intro sin hacer nada, sino que ahora usará un
do-while que compruebe si pulsa ESC (para salir) o flecha izquierda o flecha
derecha (para mover la nave: sus códigos son ConsoleKey.LeftArrow y ConsoleKey.
RightArrow). Si se pulsan las flechas, la nave se moverá a un lado o a otro (con los
métodos que acabas de crear). Al principio de cada pasada del do-while se borrará
la pantalla ("Console.Clear();")*/
class Juego
{
    public void Lanzar()
    {
        Bienvenida b = new Bienvenida();
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

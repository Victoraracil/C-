using System;
/*(6.5.1) Crea un proyecto a partir del ejemplo 06.05a, en el que cada clase esté en
un fichero separado. Como podrás comprobar, ahora necesitarás un "using
System" en cada fuente que vaya a utilizar la Consola.
(en vez de crear un proyecto nuevo, se ha modificado el proyecto puerta del apartado anterior)*/
class Porton : Puerta
{
    bool bloqueada;
    public void Bloquear()
    {
        bloqueada = true;
    }
    public void Desbloquear()
    {
        bloqueada = false;
    }
    public new void MostrarEstado()
    {
        Console.WriteLine("Portón.");
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Abierta: {0}", abierta);
        Console.WriteLine("Bloqueada: {0}", bloqueada);
    }
}

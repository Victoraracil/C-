using System;
/*(6.5.1) Crea un proyecto a partir del ejemplo 06.05a, en el que cada clase esté en
un fichero separado. Como podrás comprobar, ahora necesitarás un "using
System" en cada fuente que vaya a utilizar la Consola.
(en vez de crear un proyecto nuevo, se ha modificado el proyecto puerta del apartado anterior)*/
class Puerta
{
    protected int ancho; // Ancho en centímetros
    protected int alto; // Alto en centímetros
    protected int color; // Color en formato RGB
    protected bool abierta; // Abierta o cerrada
    public void Abrir()
    {
        abierta = true;
    }
    public void Cerrar()
    {
        abierta = false;
    }
    public int GetAncho()
    {
        return ancho;
    }
    public void SetAncho(int nuevoValor)
    {
        ancho = nuevoValor;
    }
    public void MostrarEstado()
    {
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Abierta: {0}", abierta);
    }
}
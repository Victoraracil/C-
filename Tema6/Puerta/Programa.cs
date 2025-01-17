using System;
/*(6.5.1) Crea un proyecto a partir del ejemplo 06.05a, en el que cada clase esté en
un fichero separado. Como podrás comprobar, ahora necesitarás un "using
System" en cada fuente que vaya a utilizar la Consola.
(en vez de crear un proyecto nuevo, se ha modificado el proyecto puerta del apartado anterior)*/
class Programa
{
    static void Main()
    {
        Puerta p = new Puerta();
        Console.WriteLine("Valores iniciales...");
        p.MostrarEstado();
        Console.WriteLine();
        Console.WriteLine("Vamos a abrir...");
        p.Abrir();
        p.SetAncho(80);
        p.MostrarEstado();
        Console.WriteLine();
        Console.WriteLine("Ahora el portón...");
        Porton p2 = new Porton();
        p2.SetAncho(300);
        p2.Bloquear();
        p2.MostrarEstado();
    }
}
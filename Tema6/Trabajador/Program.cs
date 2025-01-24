using System;
/*Crea un único fuente que contenga las siguientes clases:
 Una clase Trabajador, cuyo constructor escriba en pantalla "Soy un
trabajador".
 Una clase Programador, que derive de Trabajador, cuyo constructor escriba
en pantalla "Soy programador".
 Una clase Analista, que derive de Trabajador, cuyo constructor escriba en
pantalla "Soy analista".
 Una clase Ingeniero, que derive de Trabajador, cuyo constructor escriba en
pantalla "Soy ingeniero".
 Una clase IngenieroInformatico, que derive de Ingeniero, cuyo constructor
escriba en pantalla "Soy ingeniero informático".
 Una clase "PruebaDeTrabajadores", que cree un objeto perteneciente a
cada una de esas clases.*/

class PruebaDeTrabajadores
{
    public static void Main()
    {
        Trabajador trabajador = new Trabajador();
        Console.WriteLine();
        Programador programador = new Programador();
        Console.WriteLine();
        Analista analista = new Analista();
        Console.WriteLine();
        Ingeniero ingeniero = new Ingeniero();
        Console.WriteLine();
        IngenieroInformatico ingenieroInformatico = new IngenieroInformatico();
    }
}

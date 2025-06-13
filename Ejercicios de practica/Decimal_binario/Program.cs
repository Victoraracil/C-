using System;
/*
 * Crea un programa se encargue de transformar un número
 * decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.
 */
public class Program
{
    public static void Main(string[] args)
    {
        Conversor conversor = new Conversor();
        Console.WriteLine(conversor.DecimalABinario(4));
    }
}
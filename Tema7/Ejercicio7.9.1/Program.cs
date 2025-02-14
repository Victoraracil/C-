using System;
using System.Collections.Generic;
/*Usando esta misma estructura de programa, crea una clase "Cola", que
permita introducir datos (números enteros) y obtenerlos en modo FIFO (el primer
dato que se introduzca debe ser el primero que se obtenga). Debe tener un
método "Encolar" y otro "Desencolar".*/

class PilaString
{
    string[] datosPila;
    int posicionPila;
    const int MAXPILA = 200;
    // Constructor
    public PilaString()
    {
        posicionPila = 0;
        datosPila = new string[MAXPILA];
    }
    // Añadir a la pila: Apilar
    public void Apilar(string nuevoDato)
    {
        if (posicionPila == MAXPILA)
            Console.WriteLine("Pila llena!");
        else
        {
            datosPila[posicionPila] = nuevoDato;
            posicionPila++;
        }
    }
    // Extraer de la pila: Desapilar
    public string Desapilar()
    {
        if (posicionPila < 0)
            Console.WriteLine("Pila vacia!");
        else
        {
            posicionPila--;
            return datosPila[posicionPila];
        }
        return null;
    }
    public static void Main()
    {
        string palabra;
        PilaString miPila = new PilaString();
        miPila.Apilar("Hola,");
        miPila.Apilar("soy");
        miPila.Apilar("yo");
        for (byte i = 0; i < 3; i++)
        {
            palabra = (string)miPila.Desapilar();
            Console.WriteLine(palabra);
        }

        int numero;
        Cola1 miCola = new Cola1();
        miCola.Encolar(1);
        miCola.Encolar(2);
        miCola.Encolar(3);
        for (byte i = 0; i < 3; i++)
        {
            numero = miCola.Desencolar();
            Console.WriteLine(numero);
        } // Fin del Main de prueba
    }
}
using System;
using System.Collections.Generic;
/*Usando esta misma estructura de programa, crea una clase "Cola", que
permita introducir datos (números enteros) y obtenerlos en modo FIFO (el primer
dato que se introduzca debe ser el primero que se obtenga). Debe tener un
método "Encolar" y otro "Desencolar".*/
class Cola1
{
    int[] datosCola;
    int posicionCola;
    const int MAXCOLA = 200;
    // Constructor
    public Cola1()
    {
        posicionCola = 0;
        datosCola = new int[MAXCOLA];
    }
    // Añadir a la cola: Encolar
    public void Encolar(int nuevoDato)
    {
        if (posicionCola == MAXCOLA)
            Console.WriteLine("Cola llena!");
        else
        {
            datosCola[posicionCola] = nuevoDato;
            posicionCola++;
        }
    }
    // Extraer de la cola: Desencolar
    public int Desencolar()
    {
        if (posicionCola < 0)
            Console.WriteLine("Cola vacia!");
        else
        {
            int dato = datosCola[0];
            for (int i = 0; i < posicionCola - 1; i++)
                datosCola[i] = datosCola[i + 1];
            posicionCola--;
            return dato;
        }
        return -1;
    }
}

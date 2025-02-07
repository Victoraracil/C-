using System;
using System.Collections.Generic;

class PilaFalsa
{
    int tamaño;

    public PilaFalsa(int tamaño)
    {
        this.tamaño = tamaño;
        int[] pila = new int[tamaño];

    }
    public void SetNumero(int numero, int i)
    {
        pila[i] = numero;
    }
    public int GetNumero(int i)
    {
        return pila[i];
    }
    public void MostrarPila()
    {
        for (int i = pila.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(pila[i]);
        }
    }
    public int GetTamaño()
    {
        return tamaño;
    }
    public void SetTamaño(int tamaño)
    {
        this.tamaño = tamaño;
    } 
    
}
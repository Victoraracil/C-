using System;
using System.Collections.Generic;

/*Crea una clase "ListaOrdenada" de "strings", que almacene un único dato
(no un par clave-valor como los SortedList). Debe utilizar internamente un array,
contener un método "Insertar", que añadirá un nuevo dato en orden en el array,
un "Obtener(n)", que obtenga un elemento de la lista (el número "n") sin borrarlo
de la lista, y un "Borrar(n)", que elimine el n-ésimo elemento. Deberá almacenar
"strings".*/
class ListaOrdenada
{
    private List<string> lista = new List<string>();
    public void Insertar(string dato)
    {
        lista.Add(dato);
        lista.Sort();
    }
    public string Obtener(int n)
    {
        try
        {
            return lista[n];
        }
        catch (ArgumentOutOfRangeException)
        {
            return "No existe ese elemento";
        }
    }
    public void Borrar(int n)
    {
        try
        {
            lista.RemoveAt(n);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("No existe ese elemento");
        }
    }
}


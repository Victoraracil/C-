using System;
using System.Collections.Generic;

class ListaOrdenada
{
    protected List<double> lista = new List<double>();
    public string Insertar(double dato)
    {
        try
        {
            lista.Add(dato);
            return "Elemento añadido correctamente";
        }
        catch (System.FormatException)
        {
            return "No puedes insertar texto, solo numeros";
        }
    }
    public string Obtener(int n)
    {
        try
        {
            return lista[n].ToString();
        }
        catch (ArgumentOutOfRangeException)
        {
            return "No existe ese elemento";
        }
    }
    public string Borrar(int n)
    {
        try
        {
            lista.RemoveAt(n);
            return "Elemento " + n + " eliminado";
        }
        catch (ArgumentOutOfRangeException)
        {
            return "No existe ese elemento";
        }
    }
    public string Ordenar()
    {
        lista.Sort();
        return "Lista ordenada (ten en cuenta que la posicion de algunos elementos puede haber cambiado)";
        
    }
}
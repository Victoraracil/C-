using System;
using System.Collections.Generic;

class Lista
{
    List<string> lista = new List<string>();
    public void AlmacenarLista(string texto)
    {
        
    }
    public void VaciarLista()
    {
        lista.Clear();
    }
    public bool Contains(string elemento)
    {
        if (lista.Contains(elemento))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

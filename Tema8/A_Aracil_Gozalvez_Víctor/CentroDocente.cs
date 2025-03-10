using System;
using System.Collections.Generic;

public class CentroDocente
{
    public string nombre;
    public List<Personal> listaPersonal;//Incoherencia de accesibilidad: el tipo de parámetro 'Personal' es menos accesible que el método 'Buscador.RequisitosAlumno(Personal)'

    public CentroDocente(string nombre)
    {
        this.nombre = nombre;
        listaPersonal = new List<Personal>();
    }



    public void NuevoPersonal(Personal p)//Incoherencia de accesibilidad: el tipo de parámetro 'Personal' es menos accesible que el método 'Buscador.RequisitosAlumno(Personal)'
    {
        if(ComprobarDatos(p) == false)
        {
            Console.WriteLine("Datos incorrectos");
            return;
        }
        else
        {
            listaPersonal.Add(p);
        }
            
    }

    public void EliminarPersonal(int posicion)
    {
        if (ComprobarPosicion(posicion) == true)
        {
            listaPersonal.RemoveAt(posicion - 1);
        }
        else
        {
            Console.WriteLine("No se ha encontrado el personal");
        }
    }

    public bool ComprobarPosicion(int posicion)
    {
        if (posicion < 0 || posicion > listaPersonal.Count)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public bool ComprobarDatos(Personal p)//Incoherencia de accesibilidad: el tipo de parámetro 'Personal' es menos accesible que el método 'Buscador.RequisitosAlumno(Personal)'
    {
        if (p.GetDNI() == null || p.GetNombre() == null || p.GetFechaNacimiento() == null )
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void GetLista()
    {
        foreach (Personal p in listaPersonal)
        {
            Console.WriteLine(p.ToString());
        }
    }   
}
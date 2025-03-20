using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

class GrupoDeDinosaurios
{
    List<Dinosaurio> dinosaurios = new List<Dinosaurio>();
    Random r = new Random();

    public GrupoDeDinosaurios()
    {
        AnyadirDinosaurios();
    }
    private void AnyadirDinosaurios()
    {
        dinosaurios.Add(new Dinosaurio("Dinosaurio1", r.Next(0, 51), r.Next(0, 70001)));
        dinosaurios.Add(new Dinosaurio("Dinosaurio2", r.Next(0, 51), r.Next(0, 70001)));
        dinosaurios.Add(new Dinosaurio("Dinosaurio3", r.Next(0, 51), r.Next(0, 70001)));
        dinosaurios.Add(new Dinosaurio("Dinosaurio4", r.Next(0, 51), r.Next(0, 70001)));
        dinosaurios.Add(new Dinosaurio("Dinosaurio5", r.Next(0, 51), r.Next(0, 70001)));
        dinosaurios.Add(new Dinosaurio("Dinosaurio6", r.Next(0, 51), r.Next(0, 70001)));
        dinosaurios.Add(new Dinosaurio("Dinosaurio7", r.Next(0, 51), r.Next(0, 70001)));
        dinosaurios.Add(new Dinosaurio("Dinosaurio8", r.Next(0, 51), r.Next(0, 70001)));

    }
    public void AnyadirDinosaurio(string nombre, int peso, float longitud)
    {
        dinosaurios.Add(new Dinosaurio(nombre, peso, longitud));
        Console.WriteLine("Dinosaurio añadido correctamente... ");
        Console.ReadLine();
    }
    public void BorrarTodos()
    {
        dinosaurios.RemoveAll(D => D.Nombre != " ");
    }
    public int BorrarPorNombre(string nombre)
    {
        return dinosaurios.RemoveAll(D => D.Nombre.Contains(nombre));
    }
    public void MostrarTodos()
    {
        dinosaurios.ForEach((D) => Console.WriteLine(D.ToString()));
    }
    public List<Dinosaurio> MostrarPorNombre(string nombre)
    { 
        return dinosaurios.FindAll(D => D.Nombre.Contains(nombre));
    }
    public List<Dinosaurio> MostrarPorDatos(string nombre, int peso, float longitud)
    {
        return dinosaurios.FindAll(D => D.Nombre.Contains(nombre) && D.Peso == peso && D.Longitud == longitud);
    }
    public void OrdenarDinosaurios(int orden)
    {
        switch (orden)
        {
            case 1:
                dinosaurios.Sort((D, D2) => string.Compare(D.Nombre, D2.Nombre));
                break;
            case 2:
                dinosaurios.Sort((D, D2) => D.Peso.CompareTo(D2.Peso));
                break;
            case 3:
                dinosaurios.Sort((D, D2) => D.Longitud.CompareTo(D2.Longitud));
                break;
        }

    }
}

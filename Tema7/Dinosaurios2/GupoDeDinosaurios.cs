using System;
using System.Collections.Generic;

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
    public void BorrarTodos()//cambiar a LINQ
    {
        dinosaurios.RemoveAll(D => D.Nombre != " ");
    }
    public void BorrarPorNombre(string nombre) //acabar para que borre por nombre
    {
        dinosaurios.RemoveAll(D => D.Nombre == nombre);
    }
    public void MostrarTodos()
    {
        dinosaurios.ForEach((D) => Console.WriteLine(D.ToString()));
    }
    public void MostrarPorNombre(string nombre)
    {
        var Dinosaurios = dinosaurios.Where(D => D.Nombre == nombre);
    }
    public void MostrarPorDatos(string nombre, int peso, float longitud)
    {
        var Dinosaurios = dinosaurios.Where(D => D.Nombre == nombre && D.Peso == peso && D.Longitud == longitud);
    }
    public void OrdenarDinosaurios(int orden)
    {
        switch (orden)
        {
            case 1:
                var Dinosaurios = dinosaurios.OrderBy(D => D.Nombre); break;
            case 2:
                Dinosaurios = dinosaurios.OrderBy(D => D.Peso); break;
            case 3:
                Dinosaurios = dinosaurios.OrderBy(D => D.Longitud); break;

        }

    }
}


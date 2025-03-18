using System;
using System.Collections.Generic;
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
    public void AnyadirDinosaurio()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Peso (entre 0 y 70000): ");
        int peso = Convert.ToInt32(Console.ReadLine());
        if (peso < 0 || peso > 70000)
        {
            peso = 0;
        }
        Console.Write("Longitud (entre 0 y 50): ");
        float longitud = Convert.ToInt64(Console.ReadLine());
        if (longitud < 0 || longitud > 50)
        {
            longitud = 0;
        }
        dinosaurios.Add(new Dinosaurio(nombre, peso, longitud));
        Console.WriteLine("Dinosaurio añadido correctamente... ");
        Console.ReadLine();
    }
    public void BorrarTodos()
    {

    }
    public void BorrarPorNombre(string nombre)
    {
        Console.WriteLine("Escribe el nombre del ninosaurio a eliminar");
        nombre = Console.ReadLine();
        dinosaurios.RemoveAll((D) => D.Contains(nombre));
    }
    public void MostrarTodos()
    {
        dinosaurios.ForEach((D) => Console.WriteLine(D.ToString()));
    }
    public void MostrarPorNombre(string nombre)
    { 
        dinosaurios.FindAll(D => D.Contains(nombre));
    }
    public void MostrarPorDatos(string nombre, int peso, float longitud)
    {

    }
    public void OrdenarDinosaurios()
    {

    }
}

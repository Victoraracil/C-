using System;

class Dinosaurio
{
    protected string Nombre { get; set; }
    protected int Peso { get; set; }
    protected float Longitud { get; set; }
    public Dinosaurio(string nombre, int peso, float longitud)
    {
        Nombre = nombre;
        Peso = peso;
        Longitud = longitud;
    }
    public override string ToString()
    {
        return $"{Nombre} - {Peso} - {Longitud}";
    }
}
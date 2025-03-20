using System;

class Dinosaurio
{
    public string Nombre { get; set; }
    public int Peso { get; set; }
    public float Longitud { get; set; }
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
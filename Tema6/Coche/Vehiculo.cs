using System;

class Vehiculo
{
    string marca;
    string modelo;
    int cilindrada;
    float potencia;
    public void SetMarca()
    {
        marca = Console.ReadLine();
    }
    public void SetModelo()
    {
        modelo = Console.ReadLine();
    }
    public void SetCilindrada()
    {
        cilindrada = Convert.ToInt32(Console.ReadLine());
    }
    public void SetPotencia()
    {
        potencia = Convert.ToInt32(Console.ReadLine());
    }
    public void GetMarca()
    {
        Console.WriteLine("Marca: " + marca);
    }
    public void GetModelo()
    {
        Console.WriteLine("Modelo: " + modelo);
    }
    public void GetCilindrada()
    {
        Console.WriteLine("Cilindrada: " + cilindrada);
    }
    public void GetPotencia()
    {
        Console.WriteLine("Potencia: " + potencia);
    }
}

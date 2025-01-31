using System;


// Implementación de la clase Coche
class Coche : IVehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Gasolina { get; set; }

    public Coche(string marca, string modelo, int gasolina)
    {
        Marca = marca;
        Modelo = modelo;
        Gasolina = gasolina;
    }

    public void Conducir()
    {
        if (Gasolina > 0)
        {
            Console.WriteLine($"Conduciendo {Marca} {Modelo} - Gasolina restante: {Gasolina}");
            Gasolina--;
        }
        else
        {
            Console.WriteLine($"No hay gasolina en {Marca} {Modelo}.");
        }
    }

    public void Repostar(int cantidad)
    {
        Gasolina += cantidad;
        Console.WriteLine($"Repostado {cantidad} litros. Gasolina actual: {Gasolina}");
    }

    public override string ToString()
    {
        return $"Coche: {Marca} {Modelo}, Gasolina: {Gasolina}";
    }
}

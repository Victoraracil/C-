using System;
class Coche : IVehiculo
{
    public Coche()
    {
        string marca = "Seat";
        string modelo = "Ibiza";
        int gasolina = 20;
        Conducir();
        Repostar(gasolina);
    }

    public void Conducir()
    {
        Console.WriteLine("Conduciendo coche");
    }
    public void Repostar(int x)
    {
        Console.WriteLine("Repostando coche");
    }
}


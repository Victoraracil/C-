using System;
// Definición de la interfaz IVehiculo
interface IVehiculo
{
    void Conducir();
    void Repostar(int cantidad);
}
class Program
{
    static void Main()
    {
        Coche[] coches = new Coche[5]
        {
            new Coche("Toyota", "Corolla", 2),
            new Coche("Ford", "Focus", 0),
            new Coche("Honda", "Civic", 3),
            new Coche("BMW", "Serie 3", 0),
            new Coche("Audi", "A4", 5)
        };

        foreach (Coche coche in coches)
        {
            coche.Conducir();

            while (coche.Gasolina == 0)
            {
                Console.Write($"Introduce cantidad de gasolina para {coche.Marca} {coche.Modelo}: ");
                if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
                {
                    coche.Repostar(cantidad);
                    coche.Conducir();
                }
                else
                {
                    Console.WriteLine("Cantidad inválida. Intenta de nuevo.");
                }
            }
        }
    }
}

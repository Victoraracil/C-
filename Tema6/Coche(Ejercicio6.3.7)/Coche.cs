using System;
/*Crea un proyecto a partir de la clase Coche (ejercicio 6.2.4): además de la
clase Coche, existirá una clase PruebaDeCoche, que contendrá la función "Main",
que creará un objeto de tipo coche, pedirá al usuario su marca, modelo, cilindrada
y potencia, y luego mostrará en pantalla el valor de esos datos*/

class Coche
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

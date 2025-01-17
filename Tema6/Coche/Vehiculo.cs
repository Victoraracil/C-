using System;
/*Crea dos nuevos métodos en la clase Vehiculo (ejercicio 6.6.4): uno llamado
Circular, que fijará su "velocidad" (un nuevo atributo) a 50, y otro Circular(v), que
fijará su velocidad al valor que se indique como parámetro.*/
class Vehiculo
{
    protected string marca;
    protected string modelo;
    protected int cilindrada;
    protected float potencia;
    protected int ruedas;
    protected int velocidad;
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
    public void SetRuedas(int ruedas)
    {
        this.ruedas = ruedas;
    }
    public void GetMarca()
    {
        this.marca = marca;
        return;
    }
    public void GetModelo()
    {
        this.modelo = modelo;
        return;
    }
    public void GetCilindrada()
    {
        this.cilindrada = cilindrada;
        return;
    }
    public void GetPotencia()
    {
        this.potencia = potencia; 
        return;
    }
    public void GetRuedas()
    {
        this.ruedas = ruedas;
        return;
    }
    public void Circular()
    {
        velocidad = 50;
        return;
    }
    public void Circular(int v)
    {
        velocidad = v;
        return;
    }
    public void MostrarDatos(int v)
    {
        GetMarca();
        GetModelo();
        GetCilindrada();
        GetPotencia();
        GetRuedas();
        
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Cilindrada: " + cilindrada);
        Console.WriteLine("Potencia: " + potencia);
        Console.WriteLine("Ruedas: " + ruedas);
        Console.WriteLine("Velocidad: " + v);


    }
}

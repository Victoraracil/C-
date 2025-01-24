using System;
/*Crea una versión alternativa de las clases Vehiculo, Coche, Moto (6.7.4), que
te avise del momento en que se entra a cada constructor. Crea un programa de
prueba que defina un coche y una moto, y comprueba su funcionamiento.*/
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

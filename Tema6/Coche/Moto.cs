using System;
/*Crea una versión alternativa de las clases Vehiculo, Coche, Moto (6.7.4), que
te avise del momento en que se entra a cada constructor. Crea un programa de
prueba que defina un coche y una moto, y comprueba su funcionamiento.*/
class Moto : Vehiculo
{
    public Moto()
    {
        Console.WriteLine("Creando moto...");
        this.marca = "Vespa";
        this.modelo = "Vespino";
        this.cilindrada = 45;
        this.potencia = 40;
        SetRuedas(2);
    }
}

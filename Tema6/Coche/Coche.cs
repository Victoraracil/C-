using System;
/*Crea una versión alternativa de las clases Vehiculo, Coche, Moto (6.7.4), que
te avise del momento en que se entra a cada constructor. Crea un programa de
prueba que defina un coche y una moto, y comprueba su funcionamiento.*/

class Coche : Vehiculo
{
    public Coche()
    {
        Console.WriteLine("Creando coche...");
        this.marca = "BMW";
        this.modelo = "Z4";
        this.cilindrada = 654;
        this.potencia = 345;
        SetRuedas(4);
    }
}

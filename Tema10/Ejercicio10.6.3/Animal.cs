using System;
/*• Clase Animal:
        ◦ Propiedades: nombre string, peso int.
        ◦ Constructor por defecto y un constructor completo.
        ◦ Método ToString() que devuelve un string como por ejemplo:
        “Tintín;10”
*/

public class Animal
{
    public string Nombre { get; set; }
    public int Peso { get; set; }
    public Animal() { }
    public Animal(string nombre, int peso)
    {
        Nombre = nombre;
        Peso = peso;
    }
    public override string ToString()
    {
        return (this.Nombre + ";" + this.Peso);
    }
}

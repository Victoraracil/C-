using System;
/*    • Clase Gato, , hereda de Animal y añade como atributos propios:
        ◦ propiedades: color, string.
        ◦ Constructor por defecto y un constructor completo.
        ◦ Método ToString() que devuelve un string como por ejemplo:
        “Gatunch;10;amarillo”
*/
public class Gato : Animal
{
    public string Color { get; set; }
    public Gato() { }
    public Gato(string nombre, int peso, string color) : base(nombre, peso)
    {
        Color = color;
    }
    public override string ToString()
    {
        return (base.ToString() + ";" + this.Color);
    }
}

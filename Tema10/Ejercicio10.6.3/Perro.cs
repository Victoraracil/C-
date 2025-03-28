using System;
/*• Clase Perro, hereda de Animal y añade como atributos propios:
        ◦ Propiedades: raza, string.
        ◦ Constructor por defecto y un constructor completo.
        ◦ Método ToString() que devuelve un string como por ejemplo:
        “Tintín;10;Fox Terrier”
*/
public class Perro : Animal
{
    public string Raza { get; set; }
    public Perro() { }
    public Perro(string nombre, int peso, string raza) : base(nombre, peso)
    {
        Raza = raza;
    }
    public override string ToString()
    {
        return (base.ToString() + ";" + this.Raza);
    }
}

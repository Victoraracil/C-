using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Persona
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public Persona() { }
    public Persona(string nombre, string apellidos)
    {
        Nombre = nombre;
        Apellidos = apellidos;
    }
    public override string ToString()
    {
        return (this.GetType().Name + ";" + this.Nombre + ";" + this.Apellidos);
    }
}
using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
public class Persona
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string DNI { get; set; }
    public Persona() { }
    public Persona(string nombre, string apellidos, string dni)
    {
        this.Nombre = nombre;
        this.Apellidos = apellidos;
        this.DNI = dni;
    }
    public override string ToString()
    {
        return (this.Nombre + ", " + this.Apellidos) + ", " + this.DNI;
    }
}

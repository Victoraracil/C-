using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


class Persona
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
        return (this.Nombre + ", " + this.Apellidos);
    }
}

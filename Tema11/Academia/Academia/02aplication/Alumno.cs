using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Alumno
{
    public string Dni { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Poblacion { get; set; }
    public string Telefono { get; set; }
    
    public Alumno(){}
    public Alumno(string dni, string nombre, string apellidos, string poblacion, string telefono)
    {
        Dni = dni;
        Nombre = nombre;
        Apellidos = apellidos;
        Poblacion = poblacion;
        Telefono = telefono;
    }
}
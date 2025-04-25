using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Alumno
{
    //Propiedades de la clase Alumno
    public string Dni { set; get; } //DNI del alumno
    public string Nombre { set; get; } //Nombre del alumno
    public string Apellidos { set; get; } //Apellidos del alumno
    public string Telefono { set; get; } //Teléfono del alumno
    public string Poblacion { set; get; } //Población del alumno

    public Alumno() { }
    public Alumno(string dni, string nombre, string apellidos, string telefono, string poblacion)
    {
        this.Dni = dni;
        this.Nombre = nombre;
        this.Apellidos = apellidos;
        this.Telefono = telefono;
        this.Poblacion = poblacion;
    }
}

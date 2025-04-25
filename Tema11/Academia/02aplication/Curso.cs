using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Curso
{
    //Propiedades de la clase Curso
    public string Codigo { set; get; } //Código del curso
    public string Nombre { set; get; } //Nombre del curso
    public string Descripcion { set; get; } //Descripción del curso
    public int Duracion { set; get; } //Duración del curso en horas
    public int Precio { set; get; } //Precio del curso
    public Curso() { }
    public Curso(string codigo, string nombre, string descripcion, int duracion, int precio)
    {
        this.Codigo = codigo;
        this.Nombre = nombre;
        this.Descripcion = descripcion;
        this.Duracion = duracion;
        this.Precio = precio;
    }
}

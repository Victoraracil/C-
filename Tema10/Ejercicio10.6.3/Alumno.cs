using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Alumno : Persona
{
    public string Curso { get; set; }
    //public Alumno():base() { }
    public Alumno(string nombre, string apellidos, string curso) : base(nombre, apellidos)
    {
        this.Curso = curso;
    }
    public override string ToString()
    {
        return (base.ToString() + ";" + this.Curso);
    }
}

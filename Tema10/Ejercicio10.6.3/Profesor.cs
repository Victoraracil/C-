using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Profesor : Persona
{
    public string Departamento { get; set; }
    public Profesor() : base() { }
    public Profesor(string nombre, string apellidos, string departamento) : base(nombre,
    apellidos)
    {
        this.Departamento = departamento;
    }
    public override string ToString()
    {
        return (base.ToString() + ";" + this.Departamento);
    }
}
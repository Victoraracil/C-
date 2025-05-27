using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Matricula
{
    public string Dni { get; set; }
    public string CodigoCurso { get; set; }

    public Matricula() { }
    public Matricula(string dni, string codigoCurso)
    {
        Dni = dni;
        CodigoCurso = codigoCurso;
    }
}

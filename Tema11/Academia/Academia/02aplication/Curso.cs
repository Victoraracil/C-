using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Curso
{
    public string Codigo { get; set; }
    public string Titulo { get; set; }
    public string Lugar { get; set; }
    public string NumPlaza { get; set; }
    public string Precio { get; set; }

    public Curso() { }
    public Curso(string codigo, string titulo, string lugar, string numPLaza, string precio)
    {
        Codigo = codigo;
        Titulo = titulo;
        Lugar = lugar;
        NumPlaza = numPLaza;
        Precio = precio;
    }
}

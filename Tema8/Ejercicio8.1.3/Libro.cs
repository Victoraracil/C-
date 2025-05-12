using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Libro
{
    private string titulo;
    private string autor;
    private int anioPublicacion;
    public Libro(string titulo, string autor, int anioPublicacion)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.anioPublicacion = anioPublicacion;
    }
    public override string ToString()
    {
        return $"{titulo};{autor};{anioPublicacion}";
    }
}

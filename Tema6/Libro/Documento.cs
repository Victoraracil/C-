using System;
class Documento
{
    protected string autor;
    public string titulo;
    protected string ubicacion;
    public Documento(string titulo, string autor, string ubicacion)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.ubicacion = ubicacion;
    }
    public string ToString()
    {
        return ("-Titulo: " + titulo + " -Autor: " + autor + " -Ubicacion: " + ubicacion);
    }
    public void MostrarDocumento()
    {
        Console.WriteLine(ToString());
    }
    public bool Contiene(string texto)
    {
        if (titulo.Contains(texto) || autor.Contains(texto))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


using System;
class Articulo : Documento
{
    protected string procedencia;
    public Articulo(string titulo, string autor, string ubicacion, string procedencia) : base(titulo, autor, ubicacion)
    {
        this.titulo = titulo;
        this.autor = autor; 
        this.ubicacion = ubicacion;
        this.procedencia = procedencia;
    }
    public string ToString()
    {
        return ("-Titulo: " + titulo + " -Autor: " + autor + " -Ubicacion: " + ubicacion + " -Procedencia: " + procedencia);
    }
    public bool Contiene(string texto)
    {
        if (titulo.Contains(texto) || autor.Contains(texto) || procedencia.Contains(texto))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
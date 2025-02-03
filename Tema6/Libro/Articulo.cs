using System;
class Articulo : Documento
{
    protected string procedencia;
    public Articulo(string titulo, string autor, string ubicacion, int paginas, string procedencia) : base(titulo, autor, ubicacion, paginas, procedencia)
    {
        this.titulo = titulo;
        this.autor = autor; 
        this.ubicacion = ubicacion;
        this.procedencia = procedencia;
        this.paginas = paginas;
       
    }
    public void ToString()
    {
        Console.WriteLine("-Titulo: " + titulo + " -Autor: " + autor + " -Ubicacion: " + ubicacion + " -Procedencia: " + procedencia);
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
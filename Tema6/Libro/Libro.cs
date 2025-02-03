using System;
class Libro : Documento
{
    protected int paginas;
    public Libro(string titulo, string autor, string ubicacion, int paginas, string procedencia) : base(titulo, autor, ubicacion, paginas, procedencia)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.ubicacion = ubicacion;
        this.paginas = paginas;
        this.procedencia = procedencia;
    } 
    public void ToString()
    {
        Console.WriteLine("-Titulo: " + titulo + " -Autor: " + autor + " -Ubicacion: " + ubicacion + " -Paginas: " + paginas);
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


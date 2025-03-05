using System;
class Libro : Documento
{
    protected int paginas;
    public Libro(string titulo, string autor, string ubicacion, int paginas) : base(titulo, autor, ubicacion)
    {

        this.paginas = paginas;
    } 
    public string ToString()
    {
        return ("-Titulo: " + titulo + " -Autor: " + autor + " -Ubicacion: " + ubicacion + " -Paginas: " + paginas);
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


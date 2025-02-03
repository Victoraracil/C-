using System;
class Documento
{
    protected string autor;
    public string titulo;
    protected string ubicacion;
    protected int paginas;
    protected string procedencia;
    public Documento(string titulo, string autor, string ubicacion, int paginas, string procedencia)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.ubicacion = ubicacion;
        this.paginas = paginas;
        this.procedencia = procedencia;
    }
    public void ToString()
    {
        Console.WriteLine("-Titulo: " + titulo + " -Autor: " + autor + " -Ubicacion: " + ubicacion + " -Paginas: " + paginas + " -Procedencia: " + procedencia);
    }
    public void MostrarDocumento()
    {
        ToString();
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


using System;
/*Amplía el proyecto del ejercicio 6.6.2 (Libro): la clase Libro tendrá un
segundo constructor que permita dar valores al autor y el título, pero no a la
ubicación, que tomará el valor por defecto "No detallada".*/

class Libro : Documento
{
    protected int paginas;
    public Libro(string titulo, string autor, string ubicacion)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.ubicacion = ubicacion;
    }
    public Libro()
    {
        titulo = "el Arte De La Guerra";
        autor = "Sun Tzu";
        ubicacion = "No detallada";
    }
    public void SetPaginas()
    {
        this.paginas = 200;
        return;
    }
    public void GetPaginas()
    {
        this.paginas = paginas;
    }
    public void MostrarPaginas()
    {
        GetPaginas();
        Console.WriteLine("Paginas: " + paginas);
    }
}


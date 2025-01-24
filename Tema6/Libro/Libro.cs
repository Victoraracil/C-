using System;
/*Crea una variante del proyecto Libro (ejercicio 6.7.2) en la que el
constructor de Documento escriba en pantalla "Creando documento" y el
constructor de Libro escriba en pantalla "Creando libro". Comprueba su
funcionamiento.*/

class Libro : Documento
{
    protected int paginas;
    public Libro(string titulo, string autor, string ubicacion)
    {
        Console.WriteLine("Creando libro...");
        this.titulo = titulo;
        this.autor = autor;
        this.ubicacion = ubicacion;
    }
    public Libro()
    {
        Console.WriteLine("Creando libro...");
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


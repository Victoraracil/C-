using System;
class Documento
{
    string autor;
    string titulo;
    string ubicacion;
    public void GetDocumento()
    {
        Console.WriteLine(titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Ubicacion: " + ubicacion);

    }
    public void SetDocumento(string titulo, string autor, string ubicacion)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.ubicacion = ubicacion;
    }
}


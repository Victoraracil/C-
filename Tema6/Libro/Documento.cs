using System;
/*Amplía el proyecto del ejercicio 6.6.2 (Libro): la clase Libro tendrá un
segundo constructor que permita dar valores al autor y el título, pero no a la
ubicación, que tomará el valor por defecto "No detallada".*/
class Documento
{
    protected string autor;
    protected string titulo;
    protected string ubicacion;
    public void GetTitulo()
    {
        this.titulo = titulo;
        return;
    }
    public void GetAutor()
    {
        this.autor = autor;
        return;
    }
    public void GetUbicacion()
    {
        this.ubicacion = ubicacion;
        return;
    }
    public void SetTitulo()
    {
         titulo = "Los Juegos del Hambre";
        return;
    }
    public void SetAutor()
    {
         autor = "Suzanne Collins";
        return;
    }
    public void SetUbicacion()
    {
         ubicacion = "EEUU";
        return;
    }
    public void MostrarDocumento()
    {
        GetTitulo();
        GetAutor();
        GetUbicacion();
        Console.WriteLine("Titulo: " + titulo);
        Console.WriteLine("Autor: " + autor); 
        Console.WriteLine("Ubicacion: " + ubicacion);
    }
}


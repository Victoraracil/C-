using System;
/*Crea una variante del proyecto Libro (ejercicio 6.7.2) en la que el
constructor de Documento escriba en pantalla "Creando documento" y el
constructor de Libro escriba en pantalla "Creando libro". Comprueba su
funcionamiento.*/
class Documento
{
    public Documento()
    {
        Console.WriteLine("Creando documento...");
    }

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


using System;

class Libro : Producto
{
    protected string autor { get; set; }
    protected string editorial { get; set; }
    public Libro(string nombre, double precio, int cantidad, string autor, string editorial) : base(nombre, precio, cantidad)
    {
        this.autor = autor;
        this.editorial = editorial;
    }
    public override string ImprimirDatos()
    {
        return $"Nombre: {nombreProducto}, Precio: {precioVenta}, Costo: {costoFabrica}, Autor: {autor}, Editorial: {editorial}";
    }
}
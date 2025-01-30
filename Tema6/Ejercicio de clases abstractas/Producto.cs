using System;

abstract class Producto
{
    protected string nombreProducto { get; set; }
    protected double precioVenta { get; set; }
    protected int costoFabrica { get; set; }
    public Producto(string nombre, double precio, int cantidad)
    {
        nombreProducto = nombre;
        precioVenta = precio;
        costoFabrica = cantidad;
    }
    public abstract string ImprimirDatos();
}
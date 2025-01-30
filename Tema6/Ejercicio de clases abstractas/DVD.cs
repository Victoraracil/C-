using System;

class DVD : Producto
{
    protected string director { get; set; }
    protected string genero { get; set; }
    public DVD(string nombre, double precio, int cantidad, string director, string genero) : base(nombre, precio, cantidad)
    {
        this.director = director;
        this.genero = genero;
    }
    public override string ImprimirDatos()
    {
        return $"Nombre: {nombreProducto}, Precio: {precioVenta}, Costo: {costoFabrica}, Director: {director}, Género: {genero}";
    }
}
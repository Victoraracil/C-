using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Viaje
{
    public string CiudadOrigen { get; set; }
    public string CiudadDestino { get; set; }
    public int Duracion { get; set; }
    public float Precio {  get; set; }

    public Viaje() { }
    public Viaje(string CiudadOrigen, string CiudadDestino, int Duracion, float Precio)
    {
        this.CiudadOrigen = CiudadOrigen;
        this.CiudadDestino = CiudadDestino;
        this.Duracion = Duracion;
        this.Precio = Precio;
    }

    public override string ToString()
    {
        return this.GetType() + ";" + this.CiudadOrigen + " ; " + this.CiudadDestino + " ; " + this.Duracion + " ; " + this.Precio;
    }
}

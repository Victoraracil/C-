using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Autobus : Viaje
{
    public int Valoracion { get; set; }
    public bool TieneTV { get; set; }
    public Autobus() { }
    public Autobus(string CiudadOrigen, string CiudadDestino, int Duracion, float Precio, int Valoracion, bool TieneTV) : base(CiudadOrigen, CiudadDestino, Duracion, Precio)
    {
        this.Valoracion = Valoracion;
        this.TieneTV = TieneTV;
    }
    public override string ToString()
    {
        return base.ToString() + " ; " + this.Valoracion + " ; " + this.TieneTV;
    }

}
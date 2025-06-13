using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tren : Viaje
{
    public int NumAnden { get; set; }
    public string EstacionOrigen { get; set; }
    public string EstacionDestino { get; set; }

    public Tren() { }
    public Tren (string CiudadOrigen, string CiudadDestino, int Duracion, float Precio, int NumAnden, string EstacionOrigen, string EstacionDestino) : base(CiudadOrigen, CiudadDestino, Duracion, Precio)
    {
        this.NumAnden = NumAnden;
        this.EstacionOrigen = EstacionOrigen;
        this.EstacionDestino = EstacionDestino;
    }
    public override string ToString()
    {
        return base.ToString() + " ; " + this.NumAnden + " ; " + this.EstacionOrigen + " ; " + this.EstacionDestino;
    }


}

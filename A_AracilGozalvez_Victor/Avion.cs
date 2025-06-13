using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Avion : Viaje
{
    public string NumVuelo {  get; set; }
    public string AeropuertoOrigen { get; set; }
    public string AeropuertoDestino { get; set; }

    public Avion() { }
    public Avion (string CiudadOrigen, string CiudadDestino, int Duracion, float Precio, string NumVuelo, string AeropuertoOrigen, string AeropuertoDestino) : base(CiudadOrigen, CiudadDestino, Duracion, Precio)
    {
        this.NumVuelo = NumVuelo;
        this.AeropuertoOrigen = AeropuertoOrigen;
        this.AeropuertoDestino = AeropuertoDestino;
    }

    public override string ToString()
    {
        return base.ToString() + " ; " + this.NumVuelo + " ; " + this.AeropuertoOrigen + " ; " + this.AeropuertoDestino;
    }

}
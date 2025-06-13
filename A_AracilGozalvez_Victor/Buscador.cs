using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Buscador
{
    public static List<Viaje> BuscarPorOrigen(List<Viaje> viajes, string CiudadOrigen)
    {

        return viajes.FindAll(v => v.CiudadOrigen == CiudadOrigen);
    }
    public static List<Viaje> BuscarPorOrigenYPrecio(List<Viaje> viajes, string CiudadOrigen, int precio)
    {
        return BuscarPorOrigen(viajes, CiudadOrigen).FindAll(v => v.Precio == precio);
    }
    public static List<Viaje> BuscarPorOrigenPrecioYTipo(List<Viaje> viajes, string CiudadOrigen, int precio, string tipo)
    {
        //return viajes.FindAll(v => v.CiudadOrigen == CiudadOrigen && v.Precio == precio);
        return BuscarPorOrigenYPrecio(viajes, CiudadOrigen, precio).FindAll(v => v.GetType().Name == tipo);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Buscador
{
    public static List<Deporte> BuscarPorFecha(List<Deporte> deportes, DateTime fechaInicio)
    {

        return deportes.FindAll(d => d.fechaInicio == fechaInicio);
    }
    public static List<Deporte> BuscarPorTipo(List<Deporte> deportes, string tipo)
    {

        return deportes.FindAll(v => v.GetType().Name == tipo);
    }
    public static List<Deporte> BuscarPorParticipantes(List<Deporte> deportes, int numeroParticipantes)
    {

        return deportes.FindAll(v => v.numeroParticipantes == numeroParticipantes);
    }
    public static List<Deporte> BuscarPorNombre(List<Deporte> deportes, string nombreDeporte)
    {
        return deportes.FindAll(d => d.nombreDeporte == nombreDeporte);
    }
}
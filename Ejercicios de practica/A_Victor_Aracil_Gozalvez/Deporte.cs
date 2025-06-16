using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Deporte
{
    public string nombreDeporte { get; set; }
    public int numeroParticipantes { get; set; }
    public DateTime? fechaInicio { get; set; }
    public DateTime? fechaFin { get; set; }
    public Deporte() { }
    public Deporte(string nombreParticipantes, int numeroParticipantes, DateTime? fechaInicio, DateTime? fechaFin)
    {
        this.nombreDeporte = nombreParticipantes;
        this.numeroParticipantes = numeroParticipantes;
        this.fechaInicio = fechaInicio;
        this.fechaFin = fechaFin;
    }

    public override string ToString()
    {
        return nombreDeporte + ";" + numeroParticipantes + ";" + fechaInicio + ";" + fechaFin + ";";
    }
}

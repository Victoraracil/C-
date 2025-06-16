using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DeporteIndividual : Deporte
{
    public int numeroPruebas { get; set; }
    public bool gruposClasificados { get; set; }
    public DeporteIndividual() { }
    public DeporteIndividual(string nombreDeporte, int numeroParticipantes, DateTime? fechaInicio, DateTime? fechaFin, int numeroPruebas, bool gruposClasificados) : base(nombreDeporte, numeroParticipantes, fechaInicio, fechaFin)
    {
        this.numeroPruebas = numeroPruebas;
        this.gruposClasificados = gruposClasificados;
    }
    public string ToString()
    {
        return GetType() + base.ToString() + numeroPruebas + ";" + gruposClasificados + ";";
    }
}

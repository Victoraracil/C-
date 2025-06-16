using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DeporteColectivo : Deporte
{
    public int gruposClasificatorios {  get; set; }
    public int equiposClasificados { get; set; }
    public DeporteColectivo() { }
    public DeporteColectivo (string nombreDeporte, int numeroParticipantes, DateTime? fechaInicio, DateTime? fechaFin, int gruposClasificatorios, int equiposClasificados) : base(nombreDeporte, numeroParticipantes, fechaInicio, fechaFin)
    {
        this.gruposClasificatorios = gruposClasificatorios;
        this.equiposClasificados = equiposClasificados;
    }
    public string ToString()
    {
        return GetType() + base.ToString() + gruposClasificatorios + ";" + equiposClasificados + ";";
    }
}
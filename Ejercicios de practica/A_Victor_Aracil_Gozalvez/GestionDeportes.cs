using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

public class GestionDeportes
{
    public static string Ruta { get; set; } = "../../../deportes.xml";
    public static List<Deporte> Cargar()
    {
        if (!File.Exists(Ruta))
        {
            return new List<Deporte>();
        }
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Deporte>),
            new Type[] { typeof(DeporteIndividual), typeof(DeporteColectivo)});
            Stream stream = new FileStream(Ruta, FileMode.Open);
            List<Deporte> deportes = (List<Deporte>)serializer.Deserialize(stream);
            stream.Close();
            return (deportes != null ? deportes : new List<Deporte>());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return new List<Deporte>();
        }

    }
    public static void Guardar(List<Deporte> deportes)
    {
        try
        {
            StreamWriter stream = new StreamWriter(Ruta);
            XmlSerializer Serializer = new XmlSerializer(typeof(List<Deporte>),
            new Type[] { typeof(DeporteIndividual), typeof(DeporteColectivo) });
            Serializer.Serialize(stream, deportes);
            stream.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

public class GestionFichero
{
    public static string Ruta { get; set; } = "../../../viajes.xml";
    public static List<Viaje> Cargar()
    {
        if (!File.Exists(Ruta))
        {
            return new List<Viaje>();
        }
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Viaje>),
            new Type[] { typeof(Avion), typeof(Autobus), typeof(Tren) });
            Stream stream = new FileStream(Ruta, FileMode.Open);
            List<Viaje> viajes = (List<Viaje>)serializer.Deserialize(stream);
            stream.Close();
            return (viajes != null ? viajes : new List<Viaje>());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return new List<Viaje>();
        }
        
    }
    public static void Guardar( List<Viaje> viajes)
    {
        try
        {
            StreamWriter stream = new StreamWriter(Ruta);
            XmlSerializer Serializer = new XmlSerializer(typeof(List<Viaje>),
            new Type[] { typeof(Avion), typeof(Autobus), typeof(Tren) });
            Serializer.Serialize(stream, viajes);
            stream.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}

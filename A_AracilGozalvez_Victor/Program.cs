using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class Program
{
    
    public static void Main(string[] args)
    {
        List<Viaje> viajes = GestionFichero.Cargar();
        string op;
        do
        {
            Console.Clear();
            Console.WriteLine("0 - Salir");
            Console.WriteLine("1 - Nuevo Viaje");
            Console.WriteLine("2 - Buscar viajes");

            op = Console.ReadLine();

            switch (op)
            {
                case "0":
                    GestionFichero.Guardar(viajes);
                    break;
                case "1":
                    Console.WriteLine("Elije el tipo de viaje: ");
                    Console.WriteLine("1 - Avion");
                    Console.WriteLine("2 - Tren");
                    Console.WriteLine("3 - Autobus");
                    Console.WriteLine("O pulsa ENTER para salir");

                    string op1 = Console.ReadLine();

                    switch (op1) 
                    {
                        case "1":                         
                            Console.WriteLine("Introduce la ciudad de origen");
                            string origen = Console.ReadLine();

                            Console.WriteLine("Introduce la ciudad de destino");
                            string destino = Console.ReadLine();

                            Console.WriteLine("Introduce la duracion (en minutos)");
                            int duracion = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out duracion))

                            Console.WriteLine("Introduce el precio");
                            float precio = 0.000f;
                            while (!float.TryParse(Console.ReadLine(), out precio))

                            Console.WriteLine("Introduce el numero de vuelo");
                            string NumVuelo = Console.ReadLine();

                            Console.WriteLine("Introduce el aeropuerto de origen");
                            string AeroOrigen = Console.ReadLine();

                            Console.WriteLine("Introduce el aeropuerto de destino");
                            string AeroDestino = Console.ReadLine();
                                
                            viajes.Add(new Avion(origen, destino, duracion, precio, NumVuelo, AeroOrigen, AeroDestino));
                               
                            
                            break;
                        case "2":
                            Console.WriteLine("Introduce la ciudad de origen");
                            string origen2 = Console.ReadLine();

                            Console.WriteLine("Introduce la ciudad de destino");
                            string destino2 = Console.ReadLine();

                            Console.WriteLine("Introduce la duracion (en minutos)");
                            int duracion2 = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out duracion2)) 

                            Console.WriteLine("Introduce el precio");
                            float precio2 =0.000f;
                            while (!float.TryParse(Console.ReadLine(), out precio2))

                            Console.WriteLine("Introduce el numero del anden");
                            int anden = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out anden))

                            Console.WriteLine("Introduce la estacion de origen");
                            string EstaOrigen = Console.ReadLine();

                            Console.WriteLine("Introduce la estacion de destino");
                            string EstaDestino = Console.ReadLine();

                            viajes.Add(new Tren(origen2, destino2, duracion2, precio2, anden, EstaOrigen, EstaDestino));
                                
                            break;
                        case "3":                          
                            Console.WriteLine("Introduce la ciudad de origen");
                            string origen3 = Console.ReadLine();

                            Console.WriteLine("Introduce la ciudad de destino");
                            string destino3 = Console.ReadLine();

                            Console.WriteLine("Introduce la duracion (en minutos)");
                            int duracion3 = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out duracion3))

                            Console.WriteLine("Introduce el precio");
                            float precio3 = 0.000f;
                            while (!float.TryParse(Console.ReadLine(), out precio3))

                            Console.WriteLine("Introduce la valoracion (1 a 5)-valoracion incorrecta = 0");
                            int valoracion = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out valoracion))
                            {
                                if (valoracion < 1 || valoracion > 5)
                                {
                                    valoracion = 0;
                                }
                            }
                                
                            Console.WriteLine("Introduce si dispone de television o no (1-Si  2-No)");
                            bool TV;
                            string num = Console.ReadLine();
                            if (num == "1")
                            {
                                TV = true;
                            }
                            else
                            {
                                TV = false;
                            }
                            
                            viajes.Add(new Autobus(origen3, destino3, duracion3, precio3, valoracion, TV));
                        break;
                    }
                    break;

                case "2":
                    Console.WriteLine("Como quieres buscar? ");
                    Console.WriteLine("1 - Por origen");
                    Console.WriteLine("2 - Por origen y precio");
                    Console.WriteLine("3 - Por origen precio y tipo");
                    Console.WriteLine("O pulsa ENTER para salir");

                    string op2 = Console.ReadLine();

                    switch (op2)
                    {
                        case "1":
                            Console.WriteLine("Introduce la ciudad a buscar");
                            string busqueda = Console.ReadLine();
                            Buscador.BuscarPorOrigen(viajes, busqueda).ForEach(x => Console.WriteLine(x));
                            Console.ReadLine();
                        break;
                        case "2":
                            Console.WriteLine("Introduce la ciudad a buscar");
                            busqueda = Console.ReadLine();
                            Console.WriteLine("Introduce la ciudad a buscar");
                            int precio = Convert.ToInt32(Console.ReadLine());
                            Buscador.BuscarPorOrigenYPrecio(viajes, busqueda, precio).ForEach(x => Console.WriteLine(x));
                            break;
                        case "3":
                            Console.WriteLine("Introduce la ciudad a buscar");
                            busqueda = Console.ReadLine();
                            Console.WriteLine("Introduce la ciudad a buscar");
                            precio = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Introduce la ciudad a buscar");
                            precio = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Introduce el tipo de viaje");
                            string tipo = Console.ReadLine();
                            Buscador.BuscarPorOrigenPrecioYTipo(viajes, busqueda, precio, tipo).ForEach(x => Console.WriteLine(x));
                            break;
                    }
                break;
            }
        } while (op != "0");
    }
}
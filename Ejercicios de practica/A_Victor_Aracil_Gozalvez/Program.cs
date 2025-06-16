using System;
public class Program
{
    public static void Main(string[] args)
    {
        List<Deporte> deportes = GestionDeportes.Cargar();
        string op;
        do
        {
            Console.Clear();
            Console.WriteLine("0 - Salir");
            Console.WriteLine("1 - Nuevo Deporte");
            Console.WriteLine("2 - Buscar");
            op = Console.ReadLine();

            switch (op)
            {
                case "0":
                    GestionDeportes.Guardar(deportes);
                    break;
                case "1":
                    Console.WriteLine("Elije el tipo de deporte: ");
                    Console.WriteLine("1 - Individual");
                    Console.WriteLine("2 - Colectivo");
                    Console.WriteLine("O pulsa ENTER para salir");

                    string op1 = Console.ReadLine();

                    switch (op1)
                    {
                        case "1":
                            Console.WriteLine("Introduce el nombre del deporte");
                            string nombre = Console.ReadLine();

                            Console.WriteLine("Introduce el numero de participantes");
                            int participantes = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out participantes)) ;

                            Console.WriteLine("Introduce la fecha de inicio");
                            int dia = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out dia))
                            {
                                if (dia < 0 || dia > 31)
                                {
                                    Console.WriteLine("El dia debe estar ente 1 y 31");
                                    dia = 01;
                                }
                            }
                            DateTime inicio = new DateTime(2020, 08, dia);

                            Console.WriteLine("Introduce la fecha final");
                            dia = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out dia))
                            {
                                if (dia < 0 || dia > 31)
                                {
                                    Console.WriteLine("El dia debe estar ente 1 y 31");
                                    dia = 01;
                                }
                            }
                            DateTime fin = new DateTime(2020, 08, dia);

                            Console.WriteLine("Introduce el numero de pruebas");
                            int pruebas = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out pruebas)) ;

                            Console.WriteLine("Introduce si hay grupos clasificados o no (1-Si  2-No)");
                            bool grupos;
                            string num = Console.ReadLine();
                            if (num == "1")
                            {
                                grupos = true;
                            }
                            else
                            {
                                grupos = false;
                            }

                            deportes.Add(new DeporteIndividual(nombre, participantes, inicio, fin, pruebas, grupos));
                            break;
                        case "2":
                            Console.WriteLine("Introduce el nombre del deporte");
                            string nombre2 = Console.ReadLine();

                            Console.WriteLine("Introduce el numero de participantes");
                            int participantes2 = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out participantes)) ;

                            Console.WriteLine("Introduce la fecha de inicio");
                            int dia2 = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out dia2))
                            {
                                if (dia2 < 0 || dia2 > 31)
                                {
                                    Console.WriteLine("El dia debe estar ente 1 y 31");
                                }
                            }
                            DateTime inicio2 = new DateTime(2020, 08, dia2);

                            Console.WriteLine("Introduce la fecha final");
                            dia2 = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out dia2))
                            {
                                if (dia2 < 0 || dia2 > 31)
                                {
                                    Console.WriteLine("El dia debe estar ente 1 y 31");
                                }
                            }
                            DateTime fin2 = new DateTime(2020, 08, dia2);

                            Console.WriteLine("Introduce los grupos clasificatorios");
                            int gruposClasificatorios = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out gruposClasificatorios)) ;

                            Console.WriteLine("Introduce los equipos clasificados");
                            int equiposClasificados = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out equiposClasificados)) ;

                            deportes.Add(new DeporteColectivo(nombre2, participantes2, inicio2, fin2, gruposClasificatorios, equiposClasificados));
                            break;
                    }
                break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Como quieres buscar? ");
                    Console.WriteLine("1 - Por nombre");
                    Console.WriteLine("2 - Por fecha");
                    Console.WriteLine("3 - Por tipo");
                    Console.WriteLine("4 - Por participantes");
                    Console.WriteLine("O pulsa ENTER para salir");

                    string op2 = Console.ReadLine();

                    switch (op2)
                    {
                        case "1":
                            Console.WriteLine("Introduce el nombre");
                            string busqueda = Console.ReadLine();
                            Buscador.BuscarPorNombre(deportes, busqueda).ForEach(x => Console.WriteLine(x));
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("Introduce el dia a buscar");
                            int dia3 = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out dia3))
                            {
                                if (dia3 < 0 || dia3 > 31)
                                {
                                    Console.WriteLine("El dia debe estar ente 1 y 31");
                                }
                            }
                            DateTime inicio3 = new DateTime(2020, 08, dia3);
                            Buscador.BuscarPorFecha(deportes, inicio3).ForEach(x => Console.WriteLine(x));
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine("Introduce el tipo de deporte (individual o colectivo()");
                            string tipo = Console.ReadLine();
                            Buscador.BuscarPorTipo(deportes, tipo).ForEach(x => Console.WriteLine(x));
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.WriteLine("Introduce el numero de participantes");
                            int participantes3 = 0;
                            while (!Int32.TryParse(Console.ReadLine(), out participantes3)) ;
                            Buscador.BuscarPorParticipantes(deportes, participantes3).ForEach(x => Console.WriteLine(x));
                            Console.ReadLine();
                            break;
                    }
                break;
            }
        } while (op != "0");
    }
}
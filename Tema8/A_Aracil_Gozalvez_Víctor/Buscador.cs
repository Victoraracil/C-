using System;

public class Buscador
{
    public static void ListarAlumnos(CentroDocente centro)
    {
        foreach (Personal p in centro.listaPersonal)
        {
            if (p is Alumno)
            {
                if (RequisitosAlumno(p) == true)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }
    }

    public static void ListarDepartamentos(CentroDocente centro)
    {
        foreach (Personal p in centro.listaPersonal)
        {
            if (p is Profesor)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }

    public static void ListarProfesoresPorDepartamento(CentroDocente centro, string departamento)
    {
        departamento = departamento.ToUpper();
        foreach (Personal p in centro.listaPersonal)
        {
            if (p is Profesor)
            {
                Profesor profe = (Profesor)p;
                if (profe.GetDepartamento() == departamento)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }
    }

    public static void ContarPersonalTurno(CentroDocente centro, string turno)
    {
        int contador = 0;
        foreach (Personal p in centro.listaPersonal)
        {
            if (p is PersonalAdministrativo)
            {
                PersonalAdministrativo admin = (PersonalAdministrativo)p;
                if (admin.GetTurno() == turno)
                {
                    contador++;
                }
            }
        }
        Console.WriteLine($"Hay {contador} personas trabajando en el turno de {turno}");
    }

    public static void ListarTodos(CentroDocente centro)
    {
        foreach (Personal p in centro.listaPersonal)
        {
            Console.WriteLine(p.ToString());
        }
    }   
    public static bool RequisitosAlumno(Personal p) //Incoherencia de accesibilidad: el tipo de parámetro 'Personal' es menos accesible que el método 'Buscador.RequisitosAlumno(Personal)'
    {
        if (p.GetNombre().Length > 5 && p.GetFechaNacimiento().Length > 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

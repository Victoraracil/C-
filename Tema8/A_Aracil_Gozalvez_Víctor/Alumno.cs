using System;

class Alumno : Personal
{
    private int NIA;
    private string Grupo;

    public Alumno(string dni, string nombre, string fechaNacimiento, string direccion, int telefono, int nia, string grupo) : base(dni, nombre, fechaNacimiento, direccion, telefono)
    {
        NIA = nia;
        Grupo = grupo;
    }

    public override string ToString()
    {
        return $" [Alumno]{GetDNI()}, {GetNombre()}, {GetFechaNacimiento()}, {GetDireccion()}, {GetTelefono()}, {NIA}, {Grupo}";
    }
    public void GetNIA(int nia)
    {
        NIA = nia;
    }
    public int SetNIA()
    {
        return NIA;
    }
    public void GetGrupo(string grupo)
    {
        Grupo = grupo;
    }
    public string SetGrupo()
    {
        return Grupo;
    }
}


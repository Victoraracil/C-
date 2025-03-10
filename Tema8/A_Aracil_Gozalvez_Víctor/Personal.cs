using System;

internal abstract class Personal
{
    private string DNI;
    private string Nombre;
    private string FechaNacimiento;
    private string Direccion;
    private int Telefono;

    public Personal(string dni, string nombre, string fechaNacimiento, string direccion, int telefono)
    {
        DNI = dni;
        Nombre = nombre;
        FechaNacimiento = fechaNacimiento;
        Direccion = direccion;
        Telefono = telefono;
    }

    public abstract string ToString();
    public void SetDNI(string dni)
    {
        DNI = dni;
    }
    public string GetDNI()
    {
        return DNI;
    }
    public void SetNombre(string nombre)
    {
        Nombre = nombre;
    }
    public string GetNombre()
    {
        return Nombre;
    }
    public void SetFechaNacimiento(string fechaNacimiento)
    {
        FechaNacimiento = fechaNacimiento;
    }
    public string GetFechaNacimiento()
    {
        return FechaNacimiento;
    }
    public void SetDireccion(string direccion)
    {
        Direccion = direccion;
    }
    public string GetDireccion()
    {
        return Direccion;
    }
    public void SetTelefono(int telefono)
    {
        Telefono = telefono;
    }
    public int GetTelefono()
    {
        return Telefono;
    }
}

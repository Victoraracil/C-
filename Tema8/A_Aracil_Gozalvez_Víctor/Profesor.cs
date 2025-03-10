using System;
class Profesor : Personal
{
    private string Departamento;

    public Profesor(string dni, string nombre, string fechaNacimiento, string direccion, int telefono, string departamento) : base(dni, nombre, fechaNacimiento, direccion, telefono)
    {
        Departamento = departamento;
    }

    public override string ToString()
    {
        return $" [Profesor] {GetDNI()}, {GetNombre()}, {GetFechaNacimiento()}, {GetDireccion()}, {GetTelefono()}, {Departamento}";
    }
    public void SetDepartamento(string departamento)
    {
        if (departamento.Length < 2)
        {
            Departamento = "Sin Departamento";
        }
        else
        {
            Departamento = departamento;
        }
    }
    public string GetDepartamento()
    {
        return Departamento;
    }
}

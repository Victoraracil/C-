using System;

class PersonalAdministrativo : Personal
{
    private string Turno;
    
    public PersonalAdministrativo(string dni, string nombre, string fechaNacimiento, string direccion, int telefono, string Turno) : base(dni, nombre, fechaNacimiento, direccion, telefono)
    {
        Turno = "Mañana";
    }

    public override string ToString()
    {
        return $" [Personal Administrativo] {GetDNI()}, {GetNombre()}, {GetFechaNacimiento()}, {GetDireccion()}, {GetTelefono()}, {Turno}";
    }
    public void SetTurno(string turno)
    {
        Turno = turno.ToUpper();
    }
    public string GetTurno()
    {
        return Turno;
    }   

}

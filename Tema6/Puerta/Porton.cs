using System;
class Porton : Puerta
{
    bool bloqueada;
    public void Bloquear()
    {
        bloqueada = true;
    }
    public void Desbloquear()
    {
        bloqueada = false;
    }
}

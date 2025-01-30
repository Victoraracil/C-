using System;

class EnemigoTipo3 : Enemigo
{
    public EnemigoTipo3(int x, int y) : base(x, y)
    {
        this.x = x; this.y = y;
    }
    public string imagen = ")-(";
}

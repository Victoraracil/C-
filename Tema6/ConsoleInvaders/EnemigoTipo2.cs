using System;

class EnemigoTipo2 : Enemigo
{
    public EnemigoTipo2(int x, int y) : base(x, y)
    {
        this.x = x; this.y = y;        
    }
    public string imagen = "].[";
}

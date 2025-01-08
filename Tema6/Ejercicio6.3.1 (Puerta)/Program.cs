using System;
    /*Crea un proyecto con las clases Puerta y Ejemplo_06_03a. Comprueba que
    todo funciona correctamente.*/
class Puerta
{
int ancho; // Ancho en centímetros
int alto; // Alto en centímetros
int color; // Color en formato RGB
bool abierta; // Abierta o cerrada
public void Abrir()
{
    abierta = true;
}
public void Cerrar()
{
    abierta = false;
}
public int GetAncho()
    {
        return ancho;
    }
public void SetAncho(int nuevoValor)
{
    ancho = nuevoValor;
}
public void MostrarEstado()
{
    Console.WriteLine("Ancho: {0}", ancho);
    Console.WriteLine("Alto: {0}", alto);
    Console.WriteLine("Color: {0}", color);
    Console.WriteLine("Abierta: {0}", abierta);
}
}
class Ejemplo_06_03a
{
static void Main()
{
    Puerta p = new Puerta();
    Console.WriteLine("Valores iniciales...");
    p.MostrarEstado();
    Console.WriteLine();
    Console.WriteLine("Vamos a abrir...");
    p.Abrir();
    p.SetAncho(80);
    p.MostrarEstado();
}
}
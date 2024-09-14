/*
Realiza un programa que reciba una cantidad de minutos y
muestre por pantalla a cuantas horas y minutos corresponde. 
Por ejemplo: 1000 minutos son 16 horas y 40 minutos.
*/
namespace myfirstapp5
{
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de minutos: ");
        int minutos = int.Parse(Console.ReadLine()!);
        int horas = minutos / 60;
        int minutosRestantes = minutos % 60;
        Console.WriteLine($"{minutos} minutos son {horas} horas y {minutosRestantes} minutos.");
        Console.ReadKey();
    }
}
}
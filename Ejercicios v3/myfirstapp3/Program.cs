/*
Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius.
 El valor lo debe introducir el usuario.
 */
using System;
namespace myfirstapp3
{
   class Program
{
    static void Main()
    {
        Console.Write("Ingrese la temperatura en grados Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine()!);
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine("La temperatura en grados Celsius es: " + celsius);
        Console.ReadKey();
    }
}
}

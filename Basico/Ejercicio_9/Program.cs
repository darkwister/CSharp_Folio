//Programa que lea un número y que muestre su raíz cuadrada y su raíz cúbica. 
using System;
namespace myfirstapp9
{
    class Program
    {
             static void Main()
            {
             Console.WriteLine("Ingrese el numero a procesar");
             double n1 = Convert.ToDouble(Console.ReadLine());
             double raizCuadrada = Math.Sqrt(n1);
             double raizCubica = Math.Pow(n1, 1.0/3.0);
             Console.WriteLine($"La raiz cuadrada del numero dado es {raizCuadrada} y la raiz cubica es {raizCubica}");
            }
   }    
}  
//PROGRAMA QUE LEA TRES NÚMEROS Y LOS MUESTRE EN ORDEN ASCENDENTE (DE MENOR A MAYOR)
using System;
namespace hell9
{
  class Program
  {
     static void Main()
    {
       Console.WriteLine("Ingrese el primer numero:");
        int numero1 = int.Parse(Console.ReadLine()!);
       Console.WriteLine("Ingrese el segundo numero");
        int numero2 = int.Parse(Console.ReadLine()!);
       Console.WriteLine("Ingrese el tercer numero");
        int numero3 = int.Parse(Console.ReadLine()!);

        int[] numeros = { numero1, numero2, numero3 };
        Array.Sort(numeros);

        Console.WriteLine("Los numeros en orden ascendente son:");
        foreach (int numero in numeros)
        {
          Console.WriteLine(numero);
        }
    }
  }    
}      

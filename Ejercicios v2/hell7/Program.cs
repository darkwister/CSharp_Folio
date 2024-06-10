//PROGRAMA QUE LEA UN NUMERO Y DETERMINE SI ES MÚLTIPLO DE 6.

using System;
namespace hell7
{
  class Program
  {
     static void Main()
    {
     Console.WriteLine("Ingrese un número");
        int numero = int.Parse(Console.ReadLine()!);
        if (numero%6==0)
        {
            Console.WriteLine("El número es múltiplo de 6.");
        }
        else
        {
            Console.WriteLine("El número no es múltiplo de 6.");
        }
    }    
  }      
}
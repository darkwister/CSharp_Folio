//PROGRAMA QUE LEA UN NUMERO DE DOS DÍGITOS QUE DETERMINE LA SUMA DE LOS DOS DÍGITOS.

using System;
namespace hell2
{
  class Program
  {
     static void Main()
    {
     
     Console.WriteLine("Ingrese un numero de dos digitos");
     for (int i = 0; i<1;)
     {
      int numero = int.Parse(Console.ReadLine()!);
      if (numero>=10 && numero<=99)
      {
       int decenas = numero/10;
       int unidades = numero%10;
       int SUMA = decenas + unidades;
       Console.WriteLine("La suma de las cifras de este numero es "+SUMA);
       break;
      }
      else
      {
      Console.WriteLine("Este numero no es de dos digitos");
      }
     }
    }    
  }      
}
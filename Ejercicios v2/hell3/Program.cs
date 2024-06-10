//PROGRAMA QUE LEA UN NUMERO ENTERO DE DOS DÍGITOS Y DETERMINE SI SUS DOS DÍGITOS SON IGUALES.

using System;
namespace hell3
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
        if (decenas == unidades)
        {
          Console.WriteLine("Las cifras son iguales");
        }
        else
        {
          Console.WriteLine("Las cifras son distinta");
        }
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
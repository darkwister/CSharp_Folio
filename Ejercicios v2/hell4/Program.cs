//PROGRAMA QUE LEA DOS NÚMEROS Y DETERMINE CUAL ES EL MAYOR

using System;
namespace hell4
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
        if (decenas > unidades)
        {
          Console.WriteLine("El primer digito es mayor");
        }
        else if (decenas < unidades)
        {
          Console.WriteLine("El segundo digito es mayor");
        }
        else if (decenas == unidades)
        {
          Console.WriteLine("Los digitos son iguales");
        }
        break;
      }
      else
      {
      Console.WriteLine("Este numero no es de dos digitos");
      Console.Beep(600, 500);
      }
     }
    }    
  }      
}
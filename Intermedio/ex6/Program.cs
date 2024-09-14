/*
PROGRAMA QUE LEA UN NUMERO DE TRES DÍGITOS 
(DEBE VALIDAR ESA ENTRADA) Y CALCULE LA SUMATORIA DE SUS DÍGITOS
*/
using System;
namespace hell6
{
  class Program
  {
     static void Main()
    {
     Console.WriteLine("Ingrese un numero de tres digitos");
     for (int i = 0; i<1;)
     {
      int numero = int.Parse(Console.ReadLine()!);
      if (numero>=100 && numero<=999)
      {
       int centenas = numero/100;
       int decenas = (numero/10)%10;
       int unidades = numero%10;
       int SUMA = centenas + decenas + unidades;
       Console.WriteLine("La suma de los digitos es "+SUMA);
       break;
      }
      else
      {
      Console.WriteLine("Este numero no es de tres digitos");
      }
     }
    }    
  }      
}
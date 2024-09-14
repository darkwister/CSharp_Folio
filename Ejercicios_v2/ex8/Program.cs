//PROGRAMA QUE LEA UN NUMERO DE DOS DÍGITOS Y DETERMINE SI UN DÍGITO ES MÚLTIPLO DE OTRO

using System;
namespace hell8
{
  class Program
  {
     static void Main()
    {
     Console.WriteLine("Ingrese un número");
        int numero = int.Parse(Console.ReadLine()!);
          int decenas = numero/10;
          int unidades = numero%10;
          if (decenas%unidades == 0)
        {
          Console.WriteLine($"El numero {decenas} es múltiplo de {unidades}");
        }
        else if (unidades%decenas == 0)
        {
          Console.WriteLine($"El número {unidades} es múltiplo de {decenas}");
        }
        else 
        {
          Console.WriteLine("Ninguno de los numeros es multiplo del otro");
        }
    }
  }    
}      

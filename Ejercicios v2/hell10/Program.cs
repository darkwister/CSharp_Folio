//PROGRAMA QUE LEA UN NUMERO ENTERO DE TRES DIGITOS  Y DETERMINE SI EL PRIMERO ES IGUAL AL ULTIMO.

using System;
namespace hell10
{
  class Program
  {
     static void Main()
    {
       Console.Write("Ingrese un número entero de tres dígitos: ");
        int numero = int.Parse(Console.ReadLine()!);
          int centenas = numero / 100;
          int unidades = numero % 10;

        if (centenas == unidades)
        {
            Console.WriteLine("El primer dígito es igual al último dígito.");
        }
        else
        {
            Console.WriteLine("El primer dígito no es igual al último dígito.");
        }
    }
  }    
}      

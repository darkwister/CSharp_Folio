//PROGRAMA QUE LEA UN NUMERO ENTERO DE TRES DIGITOS  Y DETERMINE SI EL PRIMERO ES IGUAL AL ULTIMO.

using System;
namespace hell11
{
  class Program
  {
     static void Main()
    {
      Console.WriteLine("Ingrese su edad");
        int edad = int.Parse(Console.ReadLine()!);
        
        if (edad>50)
      {
        Console.WriteLine("ABUELO");
      }
        else if (edad<50 && edad>=30)
      {
        Console.WriteLine("PADRE");
      }
        else
      {
        Console.WriteLine("HIJO");
      }
    }
  }    
}      

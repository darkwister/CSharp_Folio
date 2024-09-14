/*PROGRAMA QUE LEA UNA EDAD Y DEPENDIENDO DE LA EDAD SEA ABUELO, PADRE o HIJO.
Mayor de 50 es abuelo, mayor de 30 es padre, menos de 30 es hijo.
*/

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

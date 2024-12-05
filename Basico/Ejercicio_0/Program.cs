using System;
//Pide un nombre al usuario y le da la bienvenida en pantalla
//A
namespace myfirstapp
{
    class Program
   {
      static void Main()
      {
         Console.WriteLine("Identifiquese usario");
         string nombre = Console.ReadLine()!;
         Console.WriteLine("¡Bienvenido "+nombre+"!");
         Console.ReadKey();
      }
   }    
}  
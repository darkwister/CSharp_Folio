using System;

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
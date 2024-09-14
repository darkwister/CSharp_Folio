/*
Pide al usuario dos números y muestra la “distancia” entre ellos 
(el valor absoluto de su diferencia, de modo que el resultado sea siempre positivo).
*/
using System;
namespace myfirstapp8
{
    class Program
    {
             static void Main()
            {
              Console.WriteLine("Ingrese el primer numero");
              int n1 = int.Parse(Console.ReadLine()!);
              Console.WriteLine("Ingrese el segundo numero");
              int n2 = int.Parse(Console.ReadLine()!);
              int distancia = Math.Abs(n1 - n2);
              Console.WriteLine($"La distancia entre estos dos puntos es de {distancia}");
            }
   }    
}  
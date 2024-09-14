using System;
/*
Calcular el perímetro y área (son dos cálculos diferentes) de un rectángulo,
recibiendo por parte del usuario la base y la altura 
*/
namespace myfirstapp1
{
    class Program
    {
          static void Main()
      {
           Console.WriteLine("Ingrese la altura");
            int a = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Ingrese la base");
            int b = int.Parse(Console.ReadLine()!);
            int area = a*b;
            int perimetro = (2*b)+(2*a);
            Console.WriteLine("De el rectangulo mencionado, su area es igual a "+area+ " y el perimetro es igual a "+perimetro);
      }
   }    
}  
//Calcular la media (promedio) de tres números pedidos por teclado.
using System;
namespace myfirstapp4
{
    class Program
    {
             static void Main()
            {
               Console.WriteLine("Ingrese el primer numero");
               int n1 = int.Parse(Console.ReadLine()!);
               Console.WriteLine("Ingrese el segundo numero");
               int n2 = int.Parse(Console.ReadLine()!);
               Console.WriteLine("Ingrese el tercer numero");
               int n3 = int.Parse(Console.ReadLine()!);
               double promedio = Convert.ToDouble((n1+n2+n3)/3);
               Console.WriteLine("El promedio de los numeros ingresados es "+promedio);
            }
   }    
}  
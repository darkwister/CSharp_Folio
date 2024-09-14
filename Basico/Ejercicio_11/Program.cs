/*
Dadas dos variables numéricas A y B, que el usuario debe teclear, 
intercambie los valores de ambas variables y muestre cuanto valen al final las dos variables.
*/
using System;
namespace myfirstapp11
{
    class Program
    {
             static void Main()
            {
               Console.WriteLine("Ingrese su primer numero");
               int n1= int.Parse(Console.ReadLine()!);
               Console.WriteLine("Ingrese su segundo numero");
               int n2= int.Parse(Console.ReadLine()!);
               Console.WriteLine($"El valor inicial de los numeros son {n1} y {n2}");
                int sustituto = n1;
                n1 = n2;
                n2 = sustituto;
               Console.WriteLine($"El valor final de los numeros son para el primer numero {n1} y para el segundo {n2}");
            }
   }    
}  
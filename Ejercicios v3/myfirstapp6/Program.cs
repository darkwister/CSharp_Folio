/*
Un vendedor recibe un sueldo base mas un 10% extra por comisión de sus ventas. 
El desea saber cuanto recibirá a fin de mes por concepto de comisión y por concepto de salario total. 
Debe ingresar el salario del vendedor, monto vendido, realizar el calculo y mostrar los resultados.
*/
using System;
namespace myfirstapp6
{
    class Program
    {
             static void Main()
            {
          
            Console.Write("Ingrese el salario base del vendedor: ");
                double salarioBase = double.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el monto vendido por el vendedor: ");
                double Vendido = double.Parse(Console.ReadLine()!);
                double comision = Vendido * 0.1;
                double salarioTotal = salarioBase + comision;
            Console.WriteLine("Salario base :" + salarioBase);
            Console.WriteLine("Monto de comisión: " + comision);
            Console.WriteLine("Salario total: " + salarioTotal);
            Console.ReadKey();
            }
   }    
}  
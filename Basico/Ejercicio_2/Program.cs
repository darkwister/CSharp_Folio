using System;
/*
Dados dos números ingresados por el usuario, 
mostrar la suma, resta, división y multiplicación de ambos.
*/
namespace myfirstapp2
{
    class Program
    {
             static void Main()
            {
             Console.WriteLine("Ingrese su primer numero");
             int n1 = int.Parse(Console.ReadLine()!);
             Console.WriteLine("Ingrese su segundo numero");
             int n2 = int.Parse(Console.ReadLine()!);
             int suma = n1+n2;
             int resta = n1-n2;
             int multiplicacion = n1*n2;
             double division = Convert.ToDouble(n1/n2);
             Console.WriteLine("De sus dos numeros ingresados la suma es "+suma+", la resta es "+resta+", la division es "+division+", la multiplicacion es "+multiplicacion);
             Console.ReadKey();
            }
   }    
}

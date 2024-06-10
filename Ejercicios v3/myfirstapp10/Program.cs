/*Dado un número de dos cifras, diseñe un algoritmo que permita obtener el número invertido. 
Ejemplo, si se introduce 23 que muestre 32.
*/
using System;
namespace myfirstapp10
{
    class Program
    {
             static void Main()
            {
              Console.WriteLine("Ingrese un numero de dos digitos");
              for (int i = 0; i<1;)
              {
              int n = int.Parse(Console.ReadLine()!);
              if (n>=10)
              {
               int decenas= n/10;
               int unidades= n%10;
               int invertido= (unidades*10)+decenas;
               Console.WriteLine("El inverso de su numero ingresado es "+invertido);
               break;

              }
              else 
              {
               Console.WriteLine("El numero que ingreso no es de dos digitos, ingrese otro");
              }
              }
            }
   }    
}  
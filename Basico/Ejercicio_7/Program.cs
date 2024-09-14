/*
Una tienda ofrece un descuento del 15% sobre el total de la compra y 
un cliente desea saber cuanto deberá pagar finalmente por su compra. 
Ingresar el monto de la compra y mostrar los resultados.
*/
using System;
namespace myfirstapp7
{
    class Program
    {
             static void Main()
            {
               Console.WriteLine("Ingrese cuanto compro el cliente");
                  double Compra = Convert.ToDouble(Console.ReadLine());
                  double descuento = Compra*0.15;
                  double TotalCompra = Compra - descuento;
               Console.WriteLine("El descuento aplicado: " +descuento);
               Console.WriteLine("El total de la compra: " +TotalCompra);
            }
   }    
}  
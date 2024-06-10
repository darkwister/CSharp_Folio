//Pedir el nombre y los dos apellidos de una persona y mostrar las iniciales.
using System;
namespace myfirstapp12
{
    class Program
    {
             static void Main()
            {
              Console.WriteLine("Ingrese el nombre de la persona:");
              string nombre = Console.ReadLine()!;
              Console.WriteLine("Ingrese el primer apellido de la persona:");
              string apellido1 = Console.ReadLine()!;

              char inicialNombre = nombre[0];
              char inicialApellido1 = apellido1[0];
  
              Console.WriteLine("Las iniciales son:");
              Console.WriteLine(inicialNombre + "." + inicialApellido1);
            }
   }    
}  
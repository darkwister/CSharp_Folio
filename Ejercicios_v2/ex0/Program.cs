//PROGRAMA QUE LEA UN NUMERO Y DETERMINE SI ES POSITIVO O NEGATIVO, MOSTRANDO UN MENSAJE PARA CADA CASO.
using System;
namespace hell
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine()!);
            if (num > 0){
                Console.WriteLine("Este numero es positivo!");
            }
            else if(num == 0){
                Console.WriteLine("Ingresaste cero");
            }
            else{
                Console.WriteLine("")
            }
        }
    }    
}  
//PROGRAMA QUE LEA UN NUMERO Y DETERMINE SI ES POSITIVO O NEGATIVO, MOSTRANDO UN MENSAJE PARA CADA CASO.
using System;
namespace hell
{
    class Program
    {
             static void Main()
            {
              string textoAscii = @"
   ▄██████▄     ▄████████   ▄▄▄▄███▄▄▄▄      ▄████████  ▄██████▄   ▄█    █▄     ▄████████    ▄████████ 
  ███    ███   ███    ███ ▄██▀▀▀███▀▀▀██▄   ███    ███ ███    ███ ███    ███   ███    ███   ███    ███ 
  ███    █▀    ███    ███ ███   ███   ███   ███    █▀  ███    ███ ███    ███   ███    █▀    ███    ███ 
 ▄███          ███    ███ ███   ███   ███  ▄███▄▄▄     ███    ███ ███    ███  ▄███▄▄▄      ▄███▄▄▄▄██▀ 
▀▀███ ████▄  ▀███████████ ███   ███   ███ ▀▀███▀▀▀     ███    ███ ███    ███ ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   
  ███    ███   ███    ███ ███   ███   ███   ███    █▄  ███    ███ ███    ███   ███    █▄  ▀███████████ 
  ███    ███   ███    ███ ███   ███   ███   ███    ███ ███    ███ ███    ███   ███    ███   ███    ███ 
  ████████▀    ███    █▀   ▀█   ███   █▀    ██████████  ▀██████▀   ▀██████▀    ██████████   ███    ███ 
                                                                                            ███    ███";

        Console.ForegroundColor = ConsoleColor.Green;

        string[] lines = textoAscii.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

        for (int i = 0; i < lines.Length; i++)
        {
            Console.Clear();
            for (int j = 0; j <= i; j++)
            {
                Console.WriteLine(lines[j]);
            }
            Thread.Sleep(100); // Ajusta el valor según la velocidad deseada
        }

        Console.ResetColor();
        Console.WriteLine("Fin del programa. Presione cualquier tecla para salir...");
        Console.ReadKey();
            }
   }    
}  
using System;

namespace Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "Tarea de Arreglos";
            Console.WriteLine("Eliga cual programa desea ejecutar");
            Console.WriteLine("Parte I");
            Console.WriteLine("1. Numeros negativos de una cantidad de numeros definida");
            Console.WriteLine("2. Secuencia descendente desde el mayor de dos numeros solicitados");
            Console.WriteLine("3. Programa de condiciones");
            Console.WriteLine("Parte II");
            Console.WriteLine("4. Suma de nuemeros en un arreglo");
            Console.WriteLine("5. Donde esta el numero veintitres?");
            Console.WriteLine("6. Clasificacion de numeros en pares e impares");
            Console.WriteLine("7. Cinco numeros clasicificados.");
            Console.WriteLine("0. Salir");
            int opc = int.Parse(Console.ReadLine()!);
            switch (opc)
            {
                case 1: 
                    ProgramaNegativos();
                break;
                case 2: 
                    ProgramaSecuenciaDescendente();
                break;
                case 3: 
                    ProgramaMatricula();
                break;
                case 4:
                    ProgramaSuma();
                break;

                case 5:
                    ProgramaVerificacion();
                break;
                
                case 6:
                    ProgramaConteo();
                break;

                case 7:
                    ProgramaCopia();
                break;
            }

                static void ProgramaSecuenciaDescendente()
                {
                    Console.Write("Ingrese el primer numero: ");
                        int numero1 = int.Parse(Console.ReadLine()!);

                    Console.Write("Ingrese el segundo numero: ");
                        int numero2 = int.Parse(Console.ReadLine()!);

                        int inicio, fin;

                        if (numero1 > numero2)
                        {
                        inicio = numero1;
                            fin = numero2;
                        }
                        else
                        {
                            inicio = numero2;
                            fin = numero1;
                        }

                        for (int numero = inicio; numero >= fin; numero--)
                        {
                            Console.WriteLine(numero);
                        }
                }

                static void ProgramaMatricula()
                {
                    Console.Write("Introduce un numero: "); 
                    int n = int.Parse(Console.ReadLine()!);
                    
                   
                    if (n > 10 && n % 2 != 0)
                    {
                        for (int i = 100; i <= 500; i += 10)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else if (n > 10 && n % 2 == 0)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("¡Hola!");
                        }
                    }
                    else if (n <= 10)
                    {
                    Console.Write("Ingrese su nombre: ");
                    string nombre = Console.ReadLine()!;
                    Console.Write("Ingrese su Matricula: ");
                    string matricula = Console.ReadLine()!;
                        for (int i = 0; i < 15; i++)
                        {
                            Console.WriteLine($"Nombre: {nombre} Matrícula: {matricula}");
                        }
                    }
                }
                static void ProgramaSuma()
            {
                int[] numeros = new int[5];
                int suma = 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Ingrese un número: ");
                    numeros[i] = int.Parse(Console.ReadLine()!);
                }

                foreach (int numero in numeros)
                {
                    suma += numero;
                }

                Console.WriteLine("La suma de los números ingresados es: " + suma);
            }

            static void ProgramaVerificacion()
            {
                int[] numeros = new int[7];
                bool encontrado = false;

                for (int i = 0; i < 7; i++)
                {
                    Console.Write("Ingrese un numero: ");
                    numeros[i] = int.Parse(Console.ReadLine()!);
                }

                foreach (int numero in numeros)
                {
                    if (numero == 23)
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
                    Console.WriteLine("HEY TE ENCONTRE. Entre los numeros se encuentra el numero 23, hola usuario!");
                }
                else
                {
                    Console.WriteLine("Adios. El numero 23 no esta aqui, busca en otro castillo.");
                }
            }

            static void ProgramaConteo()
            {
                int[] numeros = new int[10];
                int pares = 0;
                int impares = 0;

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Ingrese un numero: ");
                    numeros[i] = int.Parse(Console.ReadLine()!);
                }

                foreach (int numero in numeros)
                {
                    if (numero % 2 == 0)
                    {
                        pares++;
                    }
                    else
                    {
                        impares++;
                    }
                }

                Console.WriteLine("Cantidad de numeros pares: " + pares);
                Console.WriteLine("Cantidad de numeros impares: " + impares);
            }

            static void ProgramaNegativos()
            {
                Console.Write("Ingrese la cantidad de numeros a procesar:");
                    int cantidadNumeros = int.Parse(Console.ReadLine()!);
                    int numerosNegativos = 0;
                    int[] numerosnegativos = new int[numerosNegativos];

                        for (int i = 0; i < cantidadNumeros; i++)
                        {
                            Console.Write("Introduce un número: ");
                            int numero = int.Parse(Console.ReadLine()!);

                            if (numero < 0)
                            {
                                numerosNegativos++;
                                numerosnegativos[numerosNegativos - 1] = numero;
                            }
                        }
                        Console.WriteLine($"Has ingresado {numerosNegativos} numeros negativos.");
                        for (int i = 0; i < numerosnegativos.Length; i++)
                        {
                            Console.Write(numerosnegativos[i] + " ");
                        }
                            Console.WriteLine("Esos son todosl los numeros negativos presentes.");
            }
            static void ProgramaCopia()
            {
                int[] arreglo1 = new int[5];
                int[] arreglo2 = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Ingrese un numero: ");
                    arreglo1[i] = int.Parse(Console.ReadLine()!);
                }

                for (int i = 0; i < 5; i++)
                {
                    if (i % 2 == 0)
                    {
                        arreglo2[i] = arreglo1[i] * 10;
                    }
                    else
                    {
                        arreglo2[i] = arreglo1[i];
                    }
                }

                Console.WriteLine("Los numeros almacenados en el primer arreglo son:");
                foreach (int numero in arreglo1)
                {
                    Console.Write(numero + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Los numeros almacenados en el segundo arreglo son:");
                foreach (int numero in arreglo2)
                {
                    Console.Write(numero + " ");
                }
                Console.WriteLine();
            }
        
    }
    }
}

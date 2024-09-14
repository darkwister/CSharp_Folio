using System;

class Program
{
    static void Main(string[] args)
    {
        string nombreUsuario;
        int numero;
        byte opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Obtener último dígito de un número");
            Console.WriteLine("3. Verificar si un número es par o impar");
            Console.WriteLine("4. Generar tabla de multiplicar");
            Console.WriteLine("5. Obtener mayor dígito de un número");
            Console.WriteLine("0. Salir");

            if (!byte.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = -1;
            }

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    nombreUsuario = ObtenerNombreUsuario();
                    Console.WriteLine(Saludar(nombreUsuario));
                    Console.ReadKey();
                break;
                case 2:
                    Console.Clear();
                    numero = ObtenerNumeroDosDigitos();
                    Console.WriteLine("ltimo dígito: " + ObtenerUltimoDigito(numero));
                    Console.ReadKey();
                break;
                case 3:
                    Console.Clear();
                    numero = ObtenerNumeroDosDigitos();
                    Console.WriteLine(VerificarParImpar(numero));
                    Console.ReadKey();
                break;
                case 4:
                    Console.Clear();
                    numero = ObtenerNumeroDosDigitos();
                    Console.WriteLine("Tabla de multiplicar:");
                    GenerarTablaMultiplicar(numero);
                    Console.ReadKey();
                break;
                case 5:
                    Console.Clear();
                    numero = ObtenerNumeroDosDigitos();
                    Console.WriteLine("El mayor digito del numero ingresado es: " + ObtenerMayorDigito(numero));
                    Console.ReadKey();
                break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    Thread.Sleep(4000);
                    Console.Clear();
                break;
                default:
                    Console.WriteLine("Invalido, ingrese otra opcion");
                    Console.Clear();
                break;
            }

            Console.WriteLine();
        } while (opcion != 0);

        Console.ReadKey();
    }

    static string ObtenerNombreUsuario()
    {
        Console.WriteLine("Ingrese su nombre:");
        string nombre = Console.ReadLine()!;
        return nombre;
    }

    static string Saludar(string nombre)
    {
        return "Hola " + nombre + "!";
    }

    static int ObtenerNumeroDosDigitos()
    {
        int numero;
        do
        {
            Console.WriteLine("Ingrese un numero de dos digitos:");
        } while (!int.TryParse(Console.ReadLine(), out numero) || numero < 10 || numero > 99);
        return numero;
    }

    static int ObtenerUltimoDigito(int numero)
    {
        return numero % 10;
    }

    static string VerificarParImpar(int numero)
    {
        string mensaje;
        if (numero % 2 == 0)
        {
            mensaje = "El numero es par.";
        }
        else
        {
            mensaje = "El numero es impar.";
        }
        return mensaje;
    }

    static void GenerarTablaMultiplicar(int numero)
    {
        int primerDigito = numero / 10;
        int segundoDigito = numero % 10;

        for (int i = 1; i <= segundoDigito; i++)
        {
            int resultado = primerDigito * i;
            Console.WriteLine(primerDigito + " x " + i + " = " + resultado);
        }
    }

    static int ObtenerMayorDigito(int numero)
    {
        int primerDigito = numero / 10;
        int segundoDigito = numero % 10;
         
        return Math.Max(primerDigito, segundoDigito);
    }
}

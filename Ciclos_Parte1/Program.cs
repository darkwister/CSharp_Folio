/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Esto es un ciclo While!");
        int n = 1;

        while (n<=100)
        {
            Console.WriteLine(n);
            n++;
        }
        Console.ReadKey();
        Console.WriteLine("Fin del programa!");
    }
}


/*

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Esto es un ciclo Do While!");
        int numero, resultado , contador = 0;

        Console.WriteLine("Inserte en numero a continuacion");
        numero = Convert.ToInt32(Console.ReadLine());

        do
        {
            resultado = numero * contador;
            Console.WriteLine(numero + " * " + contador + " = " + resultado);
            contador++;
        }
        while (contador <= 12);

        Console.ReadKey();
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Esto es un ciclo For!");
        int numero, resultado =0;
        Console.WriteLine("Inserte en numero a continuacion");
        numero = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 12; i++)
        {
            resultado = numero * i;
            Console.WriteLine(numero + " * " + i + " = " + resultado);
        }
        Console.ReadKey();
    }
}
*/

using System;

class Program
{
    //Programa que pida el nombre y la edad del usuario, 
    //y que muestre un saludo con el nombre del usuario, 
    //la cantidad de veces de la edad. 
    //(Ejemplo: si el nombre es "Luis" y la edad es 24, debe mostrar el saludo: "Hola Luis" 24 veces)
    
    static void Main(string[] args)
    {
        //Uso de While
        int i = 1;
        Console.WriteLine("Ingrese su nombre!");
        string nombre = Console.ReadLine()!;
        Console.WriteLine("Ingrese su edad!");
        int edad = Convert.ToInt32(Console.ReadLine());
        
        while (i<=edad)
        {
            Console.WriteLine("Hola " + nombre);
            i++;
        }
        
       /* Uso de Do While
        int i = 1;
        Console.WriteLine("Ingrese su nombre!");
        string nombre = Console.ReadLine()!;
        Console.WriteLine("Ingrese su edad!");
        int edad = Convert.ToInt32(Console.ReadLine());

        do 
        {
            Console.WriteLine("Hola " + nombre);
            i++;
        }
        while (i <= edad);
        

       // Uso de For
        Console.WriteLine("Ingrese su nombre!");
        string nombre = Console.ReadLine()!;
        Console.WriteLine("Ingrese su edad!");
        int edad = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= edad; i++)
        {
            Console.WriteLine("Hola " + nombre + "!");
        }
        */
    }
}


/*
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Crear un programa que reciba el nombre y la edad de una persona. 
        Si la edad de la persona es mayor que 18, mostrar un mensaje que diga "Estudia en ITLA",
        la misma cantidad de veces que la edad. En caso contrario, mostrar el mensaje solo 5 veces.
        
         // Uso de While
        int i = 1;
        Console.WriteLine("Ingrese su nombre!");
        string nombre = Console.ReadLine()!;
        Console.WriteLine("Ingrese su edad!");
        int edad = Convert.ToInt32(Console.ReadLine());
        
        if (edad >= 18)
        {
            while (i <= edad)
            {
                Console.WriteLine("Estudia en ITLA!");
                i++;
            }
        }
        else
        {
            while (i <= 5)
            {
                Console.WriteLine("Estudia en ITLA!");
                i++;
            }
        }
        
        // Uso de Do While
        int i = 1;
        Console.WriteLine("Ingrese su nombre!");
        string nombre = Console.ReadLine()!;
        Console.WriteLine("Ingrese su edad!");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            do
            {
                Console.WriteLine("Estudia en ITLA!");
                i++;
            }
            while(i <= edad);
        }
        else 
        {
            do 
            {
                Console.WriteLine("Estudia en ITLA!");
                i++;
            }
            while (i <= 5);
        }
        
        // Uso de For
        Console.WriteLine("Ingrese su nombre!");
        string nombre = Console.ReadLine()!;
        Console.WriteLine("Ingrese su edad!");
        int edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                for (int i = 1; i <= edad; i++)
                {
                    Console.WriteLine("Estudia en ITLA!");
                }
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Estudia en ITLA!");
                }
            }
        
    }
}
*/

/*
Crear un programa que pida al usuario un número. Si el numero ingresado es cero, mostrar un mensaje de error y terminar.
En caso contrario que muestre la secuencia de números desde 1 hasta el numero ingresado por el usuario.

using System;

class Program
{
    static void Main(string[] args)
    {
        Uso de While
        int i = 0;
        Console.WriteLine("Ingrese un número!");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero > 0)
        {
            Console.Clear();
            while (numero >= i)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        else
        {
            while (numero <=0 )
            {
             Main(args);
            }
        }
        Console.ReadKey();
        

        //Uso de Do While
        int i = 1;
        Console.WriteLine("Ingrese un número!");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero > 0)
        {
        Console.Clear();
        do 
        {
            Console.WriteLine(i);
            i++;
        }
        while(i<=numero);
        }
        else
        {
            do
            {
                Main(args);
            }
            while (numero <= 0);
            
        }
        

        //Uso de For
        Console.WriteLine("Ingrese un número!");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero > 0)
        {
            Console.Clear();
            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        else
        {
            for (int i = 0; i < 1; i++)
            {
                Main(args);
                i++;
            }
        }
        
    }
}
*/


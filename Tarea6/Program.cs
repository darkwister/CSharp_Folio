/*PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 1 AL 500

using System;

class Program
{
    static void Main()
    {
        //Ciclo While
        int i = 1;
        while (i <= 500)
        {
            Console.WriteLine(i);
            i++;
        }
        
        //Ciclo Do While
        int i = 1;
        do
        {
            Console.WriteLine(i);
            i++;
        }
        while (i <= 500);
    }
}
*/

/*PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 500 AL 1
using System;

class Program
{
    static void Main()
    {
        //Ciclo While
        int i = 500;
        while (i != 0)
        {
            Console.WriteLine(i);
            i--;
        }
        
        //Ciclo Do While
        int i = 500;
        do
        {
            Console.WriteLine(i);
            i--;
        }
        while (i!= 0);
    }
}
*/

/*Progama que muestre los numeros impares comprendidos en tre 1 al 100

using System;

class Program
{
    static void Main()
    {
        //Ciclo While
        int i = 0;
        while (i <= 100)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
        
        //Ciclo Do While
        int i = 0;
        do
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
        while (i <= 100);
    }
}

*/

/*PROGRAMA QUE MUESTRE EN PANTALLA LOS NUMEROS DEL 0 AL 1000, INCREMENTANDO DE 5 EN 5

using System;

class Program
{
    static void Main()
    {
        //Ciclo While
        int i = 0;
        while (i <= 1000)
        {
            Console.WriteLine(i);
            i += 5;
        }
        
        //Ciclo Do While
        int i = 0;
        do
        {
            Console.WriteLine(i);
            i += 5;
        }
        while(i<= 1000);
    }
}
*/

/*PROGRAMA QUE PIDA AL USUARIO UN NUMERO, Y MUESTR EN PANTALLA LA SECUENCIA DESCENDENTE DESDE EL NUMERO INGRESADO HASTA 0

using System;

class Program
{

    static void Main()
    {
        //Ciclo While
        Console.Write("Ingrese un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (i <= numero)
        {
            Console.WriteLine(numero - i);
            i++;
        }
        
        //Ciclo Do While
        Console.Write("Ingrese un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        do
        {
            Console.WriteLine(numero - i);
            i++;
        }
        while (i <= numero);
    }
}
*/

/*
PROGRAMA QUE PIDA AL USUARIO UN NUMERO. EL NUMERO RECIBIDO LO MULTIPLICARA POR 5. 
SI EL RESULTADO ES UN NUMERO PAR, MOSTRARA EN PANTALLA LA SECUENCIA ASCENDENTE DESDE EL NUMERO RECIBIDO HASTA EL RESULTADO DE LA MULTIPLICACION. 
EN CASO CONTRARIO, MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL RESULTADO DE LA MULTIPLICACION HASTA EL NUMERO INGRESADO.

using System;

class Program
{
    static void Main()
    {
        //Ciclo While
        Console.Write("Ingrese un numero a continuacion :");
        int numero = Convert.ToInt32(Console.ReadLine());
        int resultado = numero * 5;

        if (resultado % 2 == 0)
        {
            int i = numero;
            while (i <= resultado)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        else
        {
            int i = resultado;
            while (i >= numero)
            {
                Console.WriteLine(i);
                i--;
            }
        }
        
        //Ciclo Do While
        Console.Write("Ingresa un numero a continuacion: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int resultado = numero * 5;

        if (resultado % 2 == 0)
        {
            int i = numero;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= resultado);
        }
        else
        {
            int i = resultado;
            do
            {
                Console.WriteLine(i);
                i--;
            } while (i >= numero);
        }
    }
}
*/ 


/*PROGRAMA QUE PIDA AL USUARIO DOS NUMERO. SI EL 1ER NUMERO ES MAYOR QUE EL SEGUNDO, 
MOSTRARA LA SECUENCIA DESCENDENTE DESDE EL PRIMER NUMERO HASTA EL SEGUNDO, EN CASO CONTRARIO MOSTRAR LA SECUENCIA ASCENDENTE.
*/

using System;

class Program
{
    static void Main()
    {
        /*Ciclo While
        Console.Write("Ingrese el primer numero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        if (numero1 > numero2)
        {
            int i = numero1;
            while (i >= numero2)
            {
                Console.WriteLine(i);
                i--;
            }
        }
        else
        {
            int i = numero1;
            while (i <= numero2)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        */

        //Ciclo Do While
        Console.Write("Ingrese el primer numero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        if (numero1 > numero2)
        {
            int i = numero1;
            do
            {
                Console.WriteLine(i);
                i--;
            }
            while (i >= numero2);
        }
        else
        {
            int i = numero1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= numero2);
        }
    }
}


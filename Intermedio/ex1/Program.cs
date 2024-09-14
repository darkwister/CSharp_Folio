using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 2, 5, 9 };
        int rangoInicio = 1;
        int rangoFin = 10;

        Console.WriteLine("Array: [" + string.Join(", ", array) + "]");
        Console.WriteLine("Rango: " + rangoInicio + " al " + rangoFin);
        
        int[] elementosFaltantes = EncontrarElementosFaltantes(array, rangoInicio, rangoFin);

        Console.WriteLine("Los elementos faltantes son: [" + string.Join(", ", elementosFaltantes) + "]");
    }

    static int[] EncontrarElementosFaltantes(int[] array, int inicio, int fin)
    {
        bool[] numerosPresentes = new bool[fin - inicio + 1];

        foreach (var num in array)
        {
            if (num >= inicio && num <= fin)
            {
                numerosPresentes[num - inicio] = true;
            }
        }

        int cantidadFaltante = 0;
        for (int i = 0; i < numerosPresentes.Length; i++)
        {
            if (!numerosPresentes[i])
            {
                cantidadFaltante++;
            }
        }

        int[] elementosFaltantes = new int[cantidadFaltante];
        int index = 0;

        for (int i = 0; i < numerosPresentes.Length; i++)
        {
            if (!numerosPresentes[i])
            {
                elementosFaltantes[index] = inicio + i;
                index++;
            }
        }

        return elementosFaltantes;
    }
}

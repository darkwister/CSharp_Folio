using System;

public class Maquina
{
    public string Producto;
    public int Cantidad;
    public int Precio;
    public int valor = 5;
    public static int total;

    public Maquina(string producto, int precio)
    {
        Producto = producto;
        Cantidad = valor;
        Precio = precio;
    }

    public string Obtener()
    {
        valor = --Cantidad;
        total += Precio;

        return $"\nHaz seleccionado: {Producto}\nDisponible: {valor} items\nPrecio: {Precio}\n*** Suma Precio {total} ***";
    }

    public void Editar(int num)
    {
        valor += num;
    }
}

public class MaquinaLlamado
{
    static void Main()
    {
        Maquina[] contenedor = new Maquina[10];
        contenedor[0] = new Maquina("Lays", 30);
        contenedor[1] = new Maquina("Pepsi", 25);
        contenedor[2] = new Maquina("M&M", 70);
        contenedor[3] = new Maquina("Esponjoso (Bizcochito)", 15);
        contenedor[4] = new Maquina("Agua (Cascada)", 20);
        contenedor[5] = new Maquina("Coca-Cola 20oz", 30);
        contenedor[6] = new Maquina("Maruchan <3", 60);
        contenedor[7] = new Maquina("Barra energetica", 40);
        contenedor[8] = new Maquina("Galletas Hatuey", 10);
        contenedor[9] = new Maquina("Lays de limon", 30);

        int decision, digitos, contrasena, i;
        Console.WriteLine("Elige el número de qué eres?\n[1]Usuario\n[2]Administrador");
        decision = int.Parse(Console.ReadLine()!);

        digitos = 1298;
        i = 0;

        static void UsuarioPedidos(int i, Maquina[] contenedor)
        {
            Console.WriteLine("¿Qué producto deseas comprar?");
            foreach (var j in contenedor)
            {
                Console.WriteLine($"{i++} {j.Producto}");
            }
            i = 0;

            Console.Write("Elige: ");
            int decision = int.Parse(Console.ReadLine()!);
            Console.WriteLine(contenedor[decision].Obtener());

            if (contenedor[decision].valor == 0)
            {
                Console.WriteLine("Producto agotado, vuelve por más otro día");
            }

            Console.WriteLine("\n¿Quieres seguir ordenando?\n[1]Si o [2]No");
            decision = int.Parse(Console.ReadLine()!);
            while (decision == 1)
            {
                decision = 0;
                UsuarioPedidos(i, contenedor);
            }
        }

        static void AdminRellenar(int i, Maquina[] contenedor, int decision)
        {
            Console.WriteLine("¿Cuál producto quieres rellenar?");
            foreach (var j in contenedor)
            {
                Console.WriteLine($"{i++} {j.Producto} --- {j.valor}");
            }
            i = 0;
            Console.Write("Elige: ");
            decision = int.Parse(Console.ReadLine()!);

            if (contenedor[decision].valor <= 10)
            {
                int valorIntroducir = Math.Abs(contenedor[decision].valor - 8);
                contenedor[decision].Editar(valorIntroducir);
            }

            Console.WriteLine("\n¿Quieres seguir rellenando?\n[1]Si o [2]No");
            decision = int.Parse(Console.ReadLine()!);
            while (decision == 1)
            {
                decision = 0;
                AdminRellenar(i, contenedor, decision);
            }
        }

        switch (decision)
        {
            case 1:
                UsuarioPedidos(i, contenedor);
                break;
            case 2:
                Console.Write("Inserta tu contraseña: ");
                contrasena = int.Parse(Console.ReadLine()!);

                if (contrasena == digitos)
                {
                    AdminRellenar(i, contenedor, decision);
                }
                else
                {
                    while (contrasena != digitos)
                    {
                        Console.Write("La contraseña insertada es incorrecta, inserta de nuevo: ");
                        contrasena = int.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Número de intentos disponibles: {i}/6");

                        if (i > 6)
                        {
                            Console.WriteLine("Has agotado el número de intentos, cerraré el programa.");
                            break;
                        }
                        i++;
                    }
                }
                break;
            default:
                Console.WriteLine("No has seleccionado uno de los números mencionados anteriormente, adiós.");
                break;
        }
    }
}

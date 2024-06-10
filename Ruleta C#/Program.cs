    using System;

    class Program
    {
        public static List<string> desterrados = new List<string>();
        // Lista de nombres de estudiantes
        public static List<string> listado = new List<string>()
        {
            "Abner David Dotel Chalas", "Adrian Ernesto Cuello Almonte", "Alan Daniel De Los Santos Rodríguez",
            "Alan Tubert Perez", "Alvin Jose Moreno Cabrera", "Anderson Luis Suazo Fajardo",
            "Carlos Jose Rodriguez Fortunato", "Cesar Mario Paulino Cruz", "Dennis Rubier Batista Perez",
            "Dienely Meily Frías", "Elias Daniel Mateo Gomez", "Frairlyn Camilo Roque Suarez",
            "Frank Erick Sanchez Millon", "Gabriel Ascendio Valdez", "Genderson Santana",
            "Guillermo Antonio Rotestan Polonia", "Hamsell Enmanuel Jiménez Ceballos", "Hansel Ernesto Consuegra De La Cruz",
            "Hilda Lisa Jimenez Alcantara", "Ismael Garcial Aquino", "Jems Waner De Los Santos Alcantara",
            "Job Jefferson Peréz Cabrera", "Joshua Emanuel Fermin Rivas", "Josias Miguel Perez Santamaria",
            "Kimberly Jazlin Jimenez", "Luis Aneudy De Los Santos Tejeda", "Luisa Madeling Celedonio Polanco",
            "Ramses Emmanuel Montilla Medina", "Roils Velazquez Hilario", "Solin Alexander Mordan Acosta",
            "Vladimir Alexander De Castro Delgado", "Wilgrey Ravelo Cruz", "Yunior Abel Pérez Vásquez"
        };

        public static List<string> ausentes = new List<string>();
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            bool runProgram = true;
            

            while (runProgram)
            {
                // Se muesta el menu de inicio del programa
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(@"

                ████████████████████████████████████████████████████████████
                █▄─▄─▀█▄─▄█▄─▄▄─█▄─▀█▄─▄█▄─█─▄█▄─▄▄─█▄─▀█▄─▄█▄─▄█▄─▄▄▀█─▄▄─█
                ██─▄─▀██─███─▄█▀██─█▄▀─███▄▀▄███─▄█▀██─█▄▀─███─███─██─█─██─█
                ▀▄▄▄▄▀▀▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▀▄▀▀▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀
                ");
                Console.WriteLine("\n\n\t\t\t\t===== MENU DE INICIO =====");
                Console.WriteLine("\n\n\t\t\t\t1. Mostrar Estudiantes");
                Console.WriteLine("\n\n\t\t\t\t2. Excluir Estudiantes");
                Console.WriteLine("\n\n\t\t\t\t3. Salir");
                Console.Write("\n\n\t\t\t\tIngrese una opción: ");
                string opc = Console.ReadLine()!;
                // El switch con el llamado de las funciones respectivas.
                switch (opc)
                {
                    case "1":
                        MostrarEstudiantes(ausentes);
                        break;
                    case "2":
                        ExcluirEstudiantes();
                        break;
                    case "3":
                        runProgram = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Intente nuevamente.");
                        break;
                }
            }
        }

static void MostrarEstudiantes(List<string> ausentes)
{
    bool mostrarOtrosEstudiantes = true;

    while (mostrarOtrosEstudiantes)
    {
        Console.Clear();
        Console.WriteLine("===== Duelo =====");

        // Filtrar estudiantes disponibles excluyendo los ausentes
        List<string> estudiantesDisponibles = listado.Except(ausentes).ToList();

        // Verificar si hay suficientes estudiantes disponibles
        if (estudiantesDisponibles.Count < 2)
        {
            Console.WriteLine("Ya no hay más estudiantes.");

            Console.WriteLine(@"
   ▄██████▄     ▄████████   ▄▄▄▄███▄▄▄▄      ▄████████  ▄██████▄   ▄█    █▄     ▄████████    ▄████████ 
  ███    ███   ███    ███ ▄██▀▀▀███▀▀▀██▄   ███    ███ ███    ███ ███    ███   ███    ███   ███    ███ 
  ███    █▀    ███    ███ ███   ███   ███   ███    █▀  ███    ███ ███    ███   ███    █▀    ███    ███ 
 ▄███          ███    ███ ███   ███   ███  ▄███▄▄▄     ███    ███ ███    ███  ▄███▄▄▄      ▄███▄▄▄▄██▀ 
▀▀███ ████▄  ▀███████████ ███   ███   ███ ▀▀███▀▀▀     ███    ███ ███    ███ ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   
  ███    ███   ███    ███ ███   ███   ███   ███    █▄  ███    ███ ███    ███   ███    █▄  ▀███████████ 
  ███    ███   ███    ███ ███   ███   ███   ███    ███ ███    ███ ███    ███   ███    ███   ███    ███ 
  ████████▀    ███    █▀   ▀█   ███   █▀    ██████████  ▀██████▀   ▀██████▀    ██████████   ███    ███ 
                                                                                            ███    ███ 
");
            break;
        }

        // Variables para almacenar los estudiantes seleccionados
        string estudiante1;
        string estudiante2;

        // Variable para almacenar los roles asignados
        string rolEstudiante1;
        string rolEstudiante2;

        Console.WriteLine("Grupo de estudiantes:");

        //Se encargara de seleccionar los dos estudiantes sin que estos se repitan
        int index1 = new Random().Next(estudiantesDisponibles.Count);
        estudiante1 = estudiantesDisponibles[index1];
        estudiantesDisponibles.RemoveAt(index1);

        int index2 = new Random().Next(estudiantesDisponibles.Count);
        estudiante2 = estudiantesDisponibles[index2]; 
        estudiantesDisponibles.RemoveAt(index2);

        //Movera los estudiantes seleccionados a la lista de desterrados
        desterrados.Add(estudiante1);
        desterrados.Add(estudiante2);

        // Crear una nueva lista actualizada sin los estudiantes seleccionados
        List<string> listadoActualizado = new List<string>(listado);
        listadoActualizado.Remove(estudiante1);
        listadoActualizado.Remove(estudiante2);

        // Asignar la lista actualizada a listado
        listado = listadoActualizado; 

        // Asignar roles a los estudiantes
        rolEstudiante1 = "Desafiado";
        rolEstudiante2 = "Retador";

        // Mostrar los resultados 
        Console.WriteLine("===================NUESTROS DUELISTAS DE HOY====================");
        Console.WriteLine($"Estudiante 1: {estudiante1} es el {rolEstudiante1}");
        Console.WriteLine($"Estudiante 2: {estudiante2} es el {rolEstudiante2}");
        Console.WriteLine();
        Console.WriteLine("Si concluye antes del tiempo establecido, pulse F para continuar");
        Console.WriteLine("================================================================");

        Console.Write("Ingrese el tiempo en segundos para el duelo de estudiantes: ");
        string tiempoEntrada = Console.ReadLine()!;

        int tiempo;
        if (int.TryParse(tiempoEntrada, out tiempo))
        {
            DateTime limite = DateTime.Now.AddSeconds(tiempo);
            bool tiempoAgotado = false;

            //Aqui esta el segmento de codigo que se ejecutara durante la espera
            while (DateTime.Now < limite && !tiempoAgotado)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    //En caso de la victoria del participante se muestra un mensaje en consola y se reproduce el beep de victoria
                    if (tecla.Key == ConsoleKey.F)
                    {
                        tiempoAgotado = true;
                        Console.WriteLine("¡Increíble! ¡Lo lograste antes de que el tiempo terminara!");
                        Console.WriteLine("==========================================================================");
                        Console.WriteLine(@"
██████╗ ██╗   ██╗███████╗███╗   ██╗    ████████╗██████╗  █████╗ ██████╗  █████╗      ██╗ ██████╗ 
██╔══██╗██║   ██║██╔════╝████╗  ██║    ╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗     ██║██╔═══██╗
██████╔╝██║   ██║█████╗  ██╔██╗ ██║       ██║   ██████╔╝███████║██████╔╝███████║     ██║██║   ██║
██╔══██╗██║   ██║██╔══╝  ██║╚██╗██║       ██║   ██╔══██╗██╔══██║██╔══██╗██╔══██║██   ██║██║   ██║
██████╔╝╚██████╔╝███████╗██║ ╚████║       ██║   ██║  ██║██║  ██║██████╔╝██║  ██║╚█████╔╝╚██████╔╝
╚═════╝  ╚═════╝ ╚══════╝╚═╝  ╚═══╝       ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ ╚═╝  ╚═╝ ╚════╝  ╚═════╝ 
                        ");
                        MusicaVictoria();
                    }
                }
                Thread.Sleep(100);
            }
            //Por el contrario si el tiempo se agota, se muestra un mensaje de fin de tiempo y se reproduce el beep de fin de tiempo
            if (!tiempoAgotado)
            {
                Console.WriteLine("==========================================================================");
                Console.WriteLine(@"
███████╗██╗███╗   ██╗    ██████╗ ███████╗██╗         ████████╗██╗███████╗███╗   ███╗██████╗  ██████╗ 
██╔════╝██║████╗  ██║    ██╔══██╗██╔════╝██║         ╚══██╔══╝██║██╔════╝████╗ ████║██╔══██╗██╔═══██╗
█████╗  ██║██╔██╗ ██║    ██║  ██║█████╗  ██║            ██║   ██║█████╗  ██╔████╔██║██████╔╝██║   ██║
██╔══╝  ██║██║╚██╗██║    ██║  ██║██╔══╝  ██║            ██║   ██║██╔══╝  ██║╚██╔╝██║██╔═══╝ ██║   ██║
██║     ██║██║ ╚████║    ██████╔╝███████╗███████╗       ██║   ██║███████╗██║ ╚═╝ ██║██║     ╚██████╔╝
╚═╝     ╚═╝╚═╝  ╚═══╝    ╚═════╝ ╚══════╝╚══════╝       ╚═╝   ╚═╝╚══════╝╚═╝     ╚═╝╚═╝      ╚═════╝ 
                ");
                Console.WriteLine("==========================================================================");
                MusicaFinTiempo();
            }

            // Solicitar opción al usuario
            Console.WriteLine("Presione 'Q' para salir o cualquier otra tecla para mostrar otros estudiantes.");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            if (key.KeyChar == 'q' || key.KeyChar == 'Q')
            {
                mostrarOtrosEstudiantes = false;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Intente nuevamente.");
        }
    }

    Console.WriteLine("Programa finalizado.");
    Console.WriteLine("Presione cualquier tecla para salir...");
    Console.ReadKey();
}



        static void ExcluirEstudiantes()
    {
        bool agregarAusentes = true;

        while (agregarAusentes)
        {
            Console.Clear();
            Console.WriteLine("===== EXCLUIR ESTUDIANTES =====");
            Console.WriteLine("Estudiantes disponibles:");
            //Se muesta un listado de los estudiantes existentes enumerados
            int index = 1;
            foreach (string estudiante in listado)
            {
                Console.WriteLine(index + ". " + estudiante);
                index++;
            }
            //Solicita al usuario el numero del estudiante retirar
            Console.WriteLine();
            Console.WriteLine("Ingrese el número del estudiante a excluir o presione 'Q' para volver al menú inicial.");
            string input = Console.ReadLine()!;
            //Se hace el condicional respectivo para la salida del programa, o su ejecucion en cada caso.
            if (input.ToLower() == "q" || input.ToUpper() == "Q")
            {
                agregarAusentes = false;
            }
            else
            {
                if (int.TryParse(input, out int estudianteIndex))
                {
                    if (estudianteIndex > 0 && estudianteIndex <= listado.Count)
                    {
                        string estudiante = listado.ElementAt(estudianteIndex - 1);
                        listado.Remove(estudiante);
                        Console.WriteLine(estudiante + " excluido exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Índice inválido. Intente nuevamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Intente nuevamente.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
     static void MusicaVictoria()
        {

        int[] tonos = { 659, 783, 880, 1047, 1175, 1319, 1760, 1976 };
        int duracion = 500; 

        foreach (int tono in tonos)
        {
            Console.Beep(tono, duracion);
        }
        }

     static void MusicaFinTiempo()
     {
        int[] tonos = { 200, 400, 700, 200, 400, 700, 200, 400, 700, 200, 400, 700 };
        int duracion = 600;

        foreach (int tono in tonos)
        {
         Console.Beep(tono, duracion);
        }
     }
    }


       
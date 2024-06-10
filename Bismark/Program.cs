// See https://aka.ms/new-console-template for more information
using System;
using System.Dynamic;
using System.Linq.Expressions;
/*
namespace Bismark
{
    class Program{
        public static void Main(string[] args)
        {
            ///Setup de los colores y listas a usar en la ejecucion, asi como una listita de libros llamados desde un metodo que cree
            try{
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            bool activo = true;
            List<LibroHistorico> LibrosHistoricos = new List<LibroHistorico>{}; 
            List<LibroComic> Comics = new List<LibroComic>{};
            CrearInstancias(LibrosHistoricos, Comics);
        do{
            //Menu inicial Del sistema
            Console.Clear();
            Console.WriteLine(@"
 ▄▄▄▄▄▄▄ ▄▄▄ ▄▄▄▄▄▄▄ ▄▄▄     ▄▄▄ ▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄ 
█  ▄    █   █  ▄    █   █   █   █       █       █       █       █       █
█ █▄█   █   █ █▄█   █   █   █   █   ▄   █▄     ▄█    ▄▄▄█       █   ▄   █
█       █   █       █   █   █   █  █ █  █ █   █ █   █▄▄▄█     ▄▄█  █▄█  █
█  ▄   ██   █  ▄   ██   █▄▄▄█   █  █▄█  █ █   █ █    ▄▄▄█    █  █       █
█ █▄█   █   █ █▄█   █       █   █       █ █   █ █   █▄▄▄█    █▄▄█   ▄   █
█▄▄▄▄▄▄▄█▄▄▄█▄▄▄▄▄▄▄█▄▄▄▄▄▄▄█▄▄▄█▄▄▄▄▄▄▄█ █▄▄▄█ █▄▄▄▄▄▄▄█▄▄▄▄▄▄▄█▄▄█ █▄▄█");

            Console.WriteLine("Eliga una opcion");
            Console.WriteLine("1.Crear una nueva entrada");
            Console.WriteLine("2.Ver lista de libros");
            Console.WriteLine("3.Editar una entrada");
            Console.WriteLine("4.Eliminar una entrada");
            Console.WriteLine("0. Salir");
            byte opc = byte.Parse(Console.ReadLine()!);
            //El llamado de todos los metodos a hacer su funcion
            switch(opc){
                case 1:
                    AñadirEntrada(LibrosHistoricos, Comics);
                    LibroHistorico.ExisteciasHistorico();
                    LibroComic.GetExistenciasComic();
                break;
                case 2:
                     VerLista(LibrosHistoricos, Comics);
                break;
                case 3:
                    EditarEntrada(LibrosHistoricos, Comics);
                break;
                case 4:
                    EliminarEntrada(LibrosHistoricos, Comics);
                break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Saliendo del sistema...");
                    Console.Beep(420,400);
                    Console.Beep(400,400);
                    Console.Beep(360,400);
                    Thread.Sleep(1000);
                    activo = false;
                break;
            }
        }while(activo == true);
        }
        //Algunas exepciones 
        catch(FormatException ex){
            Console.WriteLine("Error de formato: " + ex.Message);
        }
        catch (Exception  ex)
        {
            Console.WriteLine($"Error: Se produjo un error en la ejecucion: {ex.Message}");
        }
        }
        //El metodo de precreacion de algunos objetos de prueba
        public static void CrearInstancias(List<LibroHistorico> librosHistoricos, List<LibroComic> comics){
            librosHistoricos.Add(new("Memorias de Adriano ","Marguerite Yourcenar",1951));
            comics.Add(new("Jojo's Bizarre Adventure Part 7: Steel Ball Run", "Hirohiko Araki",2004,"Fantasia"));
            librosHistoricos.Add(new("Los Pilares de la Tierra", "Ken Follett", 1989));
            comics.Add(new("Maus", "Art Spiegelman", 1986, "Historia"));
            librosHistoricos.Add(new("Cien años de soledad", "Gabriel García Márquez", 1967));
            comics.Add(new("Spider-Man","Stan Lee",1962,"Superheroes"));
        }
        //El metodo de vista 
        public static void VerLista(List<LibroHistorico> librosHistoricos, List<LibroComic> comics)
        {
            Console.WriteLine("Lista de libros historicos:");
            foreach (LibroHistorico libro in librosHistoricos){
                libro.GetInfo();
                Console.WriteLine("");
            }
            Console.WriteLine("Lista de comics:");
            foreach (LibroComic comic in comics){
                comic.GetInfo();
                Console.WriteLine("");
            }
            Console.WriteLine("\n Pulse cualquier tecla para continuar");
            Console.ReadKey();
        }
        //Metodo de edicion de los objetos
        public static void EditarEntrada(List<LibroHistorico> librosHistoricos, List<LibroComic> comics)
        {
            VerLista(librosHistoricos, comics);
            Console.Write("Ingrese el número de la entrada que desea editar (En orden de como esta  mostrado, 0 para cancelar): ");
            byte opc = byte.Parse(Console.ReadLine()!);
            if (opc == 0)
                return;
            int index = opc - 1;
            if (index < 0 || index >= librosHistoricos.Count + comics.Count)
            return;
            if (index < librosHistoricos.Count)
                {
                    LibroHistorico libro = librosHistoricos[index];
                    Console.Write("Ingrese el nuevo título: ");
                    libro.Titulo = Console.ReadLine()!;
                    Console.Write("Ingrese el nuevo autor: ");
                    libro.Autor = Console.ReadLine()!;
                    Console.Write("Ingrese el nuevo año de publicación: ");
                    libro.AñoPublicacion = int.Parse(Console.ReadLine()!);
                }
            else
            {
                index -= librosHistoricos.Count;
                LibroComic comic = comics[index];
                Console.Write("Ingrese el nuevo título: ");
                comic.Titulo = Console.ReadLine()!;
                Console.Write("Ingrese el nuevo autor: ");
                comic.Autor = Console.ReadLine()!;
                Console.Write("Ingrese el nuevo año de publicación: ");
                comic.AñoPublicacion = int.Parse(Console.ReadLine()!);
                Console.Write("Ingrese el nuevo género: ");
                comic.Genero = Console.ReadLine()!;
            }
        }
        //Metodo de eliminacion de objetos
        public static void EliminarEntrada(List<LibroHistorico> librosHistoricos, List<LibroComic> comics)
        {
            VerLista(librosHistoricos, comics);
            Console.Write("Ingrese el número de la entrada que desea eliminar (0 para cancelar): ");
            byte opc = byte.Parse(Console.ReadLine()!);

            if (opc == 0)
                return;

            int index = opc - 1;

            if (index < 0 || index >= librosHistoricos.Count + comics.Count)
                return;

            if (index < librosHistoricos.Count)
                librosHistoricos.RemoveAt(index);
            else
            {
                index -= librosHistoricos.Count;
                comics.RemoveAt(index);
            }
        }
        //Metodo de Añadir objetos
        public static void AñadirEntrada(List<LibroHistorico> librosHistoricos, List<LibroComic> comics){
            Console.Clear();
            Console.WriteLine("Que tipo de libro desea ingresar");
            Console.WriteLine("1. Crear entrada de libro historico");
            Console.WriteLine("2. Crear entrada de libro comic");
            byte oppc = byte.Parse(Console.ReadLine()!);
            switch(oppc){
            case 1:
                Console.Clear();
                Console.WriteLine("Ingrese el titulo");
                string TitHis = Console.ReadLine()!;
                Console.WriteLine("Ingrese el Autor");
                string AutHis = Console.ReadLine()!;
                Console.WriteLine("Ingrese el año de publicacion");
                int DatePubHis = int.Parse(Console.ReadLine()!);
                librosHistoricos.Add(new(TitHis, AutHis, DatePubHis));
            break;
                
            case 2:
                Console.WriteLine("Ingrese el titulo");
                string TitCom = Console.ReadLine()!;
                Console.WriteLine("Ingrese el Autor");
                string AutCom = Console.ReadLine()!;
                Console.WriteLine("Ingrese el año de publicacion");
                int DatePubCom = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Ingrese el genero del comic");
                string GenCom = Console.ReadLine()!;
                comics.Add(new(TitCom, AutCom, DatePubCom,GenCom));
            break; 
            }
        }
    }
}*/
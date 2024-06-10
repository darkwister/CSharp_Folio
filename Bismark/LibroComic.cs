using System.Dynamic;
using System.Collections;

namespace Bismark;

public class LibroComic:Libro{
    private static int ExistenciasComic{get; set;}
    public string Genero{get; set;}
    public LibroComic(string Titulo, String Autor, int AñoPublicacion, String Genero) : base(Titulo, Autor, AñoPublicacion){
        this.Genero = Genero;
        ++ExistenciasComic;
    }
    public static void GetExistenciasComic(){
        Console.WriteLine($"Hay actualmente {ExistenciasComic} comics en la biblioteca");
    }
   /* public void Enomatopeia(){
        Console.WriteLine(@"
(     ( .  (  .  (  .  (    (  ( (  (    
 )\    )\ . )\  . )\  . )\   )\ )\)\ )\   
((_)  ((() ((_)  ((_)  ((_) ((_)_)(_)(_)  
\ \    / // _ \ / _ \ / _ \/ __| || || |  
 \ \/\/ /| (_) | (_) | (_) |__ \ __ ||_|  
  \_/\_/  \___/ \___/ \___/|___/_||_|(_)  
");
        Console.Beep(200, 100);
    }
    */
}
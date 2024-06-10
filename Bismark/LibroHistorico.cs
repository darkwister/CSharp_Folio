using System.Dynamic;

namespace Bismark;

public class LibroHistorico:Libro{
        private static int ExistenciasHis{get; set;}
        public LibroHistorico(string Titulo, string Autor, int AñoPublicacion) : base(Titulo, Autor, AñoPublicacion)
        {
            ++ExistenciasHis;
        }
        public static void ExisteciasHistorico(){
            Console.WriteLine($"Hay actualmente {ExistenciasHis} libros historicos en la biblioteca");
        }
}
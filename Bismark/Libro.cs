namespace Bismark;

public class Libro
    {
        public string Titulo {get; set;}

        public string Autor {get; set;}

        public int AñoPublicacion {get; set;}

        public Libro(string Titulo, string Autor, int AñoPublicacion){
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.AñoPublicacion = AñoPublicacion;
        }
        public void GetInfo(){
            Console.WriteLine($"Titulo:{Titulo} || Autor:{Autor} || Año de Publicacion:{AñoPublicacion}");
        }
}   
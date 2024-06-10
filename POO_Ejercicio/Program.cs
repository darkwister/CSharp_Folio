using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_P2_MJ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Persona persona = new Persona();
            persona.edad = 26;
            persona.Nombre = "Juan";
            Console.WriteLine(persona.Nombre);*/

            // Polimorfismo
            Empleado emp = new EmpleadoFijo();
            //emp = new EmpleadoContratado();
            //emp = new EmpleadoHora();

            Console.Write("\n [1] Fijo \n [2]Por Contrato \n [3]Por hora \n" +
                  "Que tipo de empleado va a procesar?");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    emp = new EmpleadoFijo();
                    break;
                case 2:
                    emp = new EmpleadoContratado();
                    break;
                case 3:
                    emp = new EmpleadoHora();
                    break;
                default:
                    Console.WriteLine("Opcion Incorrecta!");
                    break;
            }
            Console.Write("Ingrese el nombre: ");
            emp.Nombre = Console.ReadLine();

            Console.Write("Ingrese el Monto: ");
            emp.Salario = int.Parse(Console.ReadLine());

            emp.Cobrar();

            Console.WriteLine(emp);
            Console.ReadKey();
        }
    }
}

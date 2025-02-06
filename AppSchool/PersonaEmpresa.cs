using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSchool
{
    public class PersonaEmpresa
    {
        public string nombreCompleto { get; set; }
        public string identificacion { get; set; }
        public int Edad { get; set; }
        public double salario { get; set; }
        public string areaTrabajo { get; set; }

        public PersonaEmpresa(string nombreCompleto, string identificacion, int Edad, double salario, string areaTrabajo) {
            this.nombreCompleto = nombreCompleto;
            this.identificacion = identificacion;
            this.Edad = Edad; 
            this.salario = salario;
            this.areaTrabajo = areaTrabajo;
        }
    }
}
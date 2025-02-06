using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSchool
{
    public class PersonaQualityAssurance : PersonaEmpresa
    {
        public PersonaQualityAssurance(string nombreCompleto, string identificacion, int Edad, double salario, string areaTrabajo) : base(nombreCompleto, identificacion, Edad, salario, areaTrabajo)
        {
            areaTrabajo = "Quality Assurance";
        }

        string probarCodigo(){
            return $"{nombreCompleto} esta probando las funcionalidades del codigo";
        }
        string codigoAprovado(){
            return $"{nombreCompleto}";
        }
    }
}
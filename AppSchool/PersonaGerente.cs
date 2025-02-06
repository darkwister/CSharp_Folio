using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSchool
{
    public class PersonaGerente : PersonaEmpresa
    {
        public PersonaGerente(string nombreCompleto, string identificacion, int Edad, double salario, string areaTrabajo) : base(nombreCompleto, identificacion, Edad, salario, areaTrabajo)
        {
            areaTrabajo = "Gerente";
        }

        private string planificarEstrategia(){
            return $"{nombreCompleto} esta planificando una estrategia";
        }

        private string SupervisarProyecto(){
            return $"{nombreCompleto} esta supervisando el proyecto!";
        }

        private string evaluarDesempeño(){
            return $"{nombreCompleto} esta evaluando el desempeño actual";
        }
    }
}
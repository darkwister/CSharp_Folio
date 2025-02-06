using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSchool
{
    public class PersonaDesarrollo : PersonaEmpresa
    {
        public PersonaDesarrollo(string nombreCompleto, string identificacion, int Edad, double salario, string areaTrabajo) : base(nombreCompleto, identificacion, Edad, salario, areaTrabajo)
        {
            areaTrabajo = "Desarrollador";
        }

        private string codificarSoftware(){
            return $"{nombreCompleto} esta codificando un modulo para un gestor de inventarios";
        }

        private string realizarPruebas(){
            return $"{nombreCompleto} esta realizando pruebas unitarias en el codigo";
        }

        private string documentarCodigo() {
            return $"{nombreCompleto} esta realizando la documentacion";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSchool
{
    public class PersonaVentas : PersonaEmpresa
    {
        public PersonaVentas(string nombreCompleto, string identificacion, int Edad, double salario, string areaTrabajo) : base(nombreCompleto, identificacion, Edad, salario, areaTrabajo)
        {
        }
        string venderSoftware(){
            return $"{nombreCompleto} esta vendiendo el sistema!";
        }
        string revisarVentas(){
            return $"{nombreCompleto} esta revisando las ventas de este mes";
        }
        string pedirDatos(){
            return $"{nombreCompleto} esta solicitando los datos para hacer una grafica";
        }
    }
}
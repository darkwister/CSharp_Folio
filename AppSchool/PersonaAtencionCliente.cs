using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSchool
{
    public class PersonaAtencionCliente : PersonaEmpresa
    {
        public PersonaAtencionCliente(string nombreCompleto, string identificacion, int Edad, double salario, string areaTrabajo) : base(nombreCompleto, identificacion, Edad, salario, areaTrabajo)
        {
            areaTrabajo = "Atencion al Cliente";
        }

        string atenderConsultas(){
            return $"{nombreCompleto} esta atendiendo las consultas de los clientes";
        }
        string resolverProblemas(){
            return $"{nombreCompleto} esta solucionando un problema de un cliente";
        }
        string proporcionarSeguimiento(){
            return $"{nombreCompleto} esta dandole seguimiento a un cliente";
        }
    }
}
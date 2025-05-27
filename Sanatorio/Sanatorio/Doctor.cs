using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio
{
    public class Doctor
    {
        public string Nombre_ap;
        public string Matricula;
        public string Especialidad;
        public bool Disponible;
        public Doctor(string nombre, string matricula, string especialidad, bool disponible)
        {
            Nombre_ap = nombre;
            Matricula = matricula;
            Especialidad = especialidad;
            Disponible = disponible;
        }

        public override string ToString()
        {
            return $"{Nombre_ap} (Matrícula: {Matricula}, Especialidad: {Especialidad}) - " +
                   $"{(Disponible ? "Disponible" : "No disponible")}";
        }
    }


}


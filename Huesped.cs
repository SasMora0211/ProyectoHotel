using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Huesped : Persona
    {
        public DateTime FechaRegistro { get; set; }

        public override string NombreCompleto()
        {
            return $"Sr. {Nombres} {Apellidos}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recepcionista : Persona
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public override string NombreCompleto()
        {
            return $"Recepcionista: {Nombres} {Apellidos}";
        }
    }
}

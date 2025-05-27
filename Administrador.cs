using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Persona
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public override string NombreCompleto()
        {
            return $"Admin: {Nombres} {Apellidos}";
        }
    }
}

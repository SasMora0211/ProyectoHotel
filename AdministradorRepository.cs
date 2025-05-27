using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datos
{
    public class AdministradorRepository : FileRepository<Administrador>
    {
        public AdministradorRepository(string ruta) : base(ruta)
        {
        }

        public override List<Administrador> Consultar()
        {
            try
            {
                List<Administrador> listaAdministrador = new List<Administrador>();
                if (!File.Exists(ruta))
                {
                    StreamReader lector = new StreamReader(ruta);
                    while (!lector.EndOfStream)
                    {
                        listaAdministrador.Add(Mappear(lector.ReadLine()));
                    }
                    lector.Close();
                }
                return listaAdministrador;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override Administrador Mappear(string datos)
        {
            Administrador administrador = new Administrador();
            string[] partes = datos.Split(';');

            administrador.Id = int.Parse(partes[0]);
            administrador.Nombres = partes[1];
            administrador.Apellidos = partes[2];
            administrador.Telefono = uint.Parse(partes[3]);
            administrador.Correo = partes[4];
            administrador.Usuario = partes[5];
            administrador.Contrasena = partes[6];
            return administrador;
        }
    }
}

using System;
using System.IO;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RecepcionistaRepository : FileRepository<Recepcionista>
    {
        public RecepcionistaRepository(string ruta) : base(ruta)
        {
        }

        public override List<Recepcionista> Consultar()
        {
            try
            {
                List<Recepcionista> listaRecepcionista = new List<Recepcionista>();
                if (!File.Exists(ruta))
                {
                    StreamReader lector = new StreamReader(ruta);
                    while (!lector.EndOfStream)
                    {
                        listaRecepcionista.Add(Mappear(lector.ReadLine()));
                    }
                    lector.Close();
                }
                return listaRecepcionista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override Recepcionista Mappear(string datos)
        {
            Recepcionista recepcionista = new Recepcionista();
            string[] partes = datos.Split(';');

            recepcionista.Id = int.Parse(partes[0]);
            recepcionista.Nombres = partes[1];
            recepcionista.Apellidos = partes[2];
            recepcionista.Telefono = uint.Parse(partes[3]);
            recepcionista.Correo = partes[4];
            recepcionista.Usuario = partes[5];
            recepcionista.Contrasena = partes[6];
            return recepcionista;
        }
    }
}

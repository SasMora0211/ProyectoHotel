using System;
using Entidades;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AdministradorService : IService<Administrador>
    {
        private readonly AdministradorRepository repositorioAdministrador;

        public AdministradorService()
        {
            repositorioAdministrador = new AdministradorRepository(Archivos.ARC_ADMINISTRADOR);
        }

        public string Guardar(Administrador entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... El administrador no puede ser nulo.");
                }

                return repositorioAdministrador.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar el administrador: {ex.Message}";
            }
        }

        public List<Administrador> Consultar()
        {
            return repositorioAdministrador.Consultar();
        }

        public string Modificar(Administrador entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... El administrador no puede ser nulo.");
                }

                return repositorioAdministrador.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar el administrador: {ex.Message}";
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Error... El ID del administrador no puede ser menor o igual a cero.");
                }

                return repositorioAdministrador.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar el administrador: {ex.Message}";
            }
        }

        public Administrador BuscarId(int id)
        {
            var administradorBuscado = Consultar().FirstOrDefault<Administrador>(x => x.Id == id);
            return administradorBuscado;
        }
    }
}

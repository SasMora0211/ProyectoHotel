using System;
using Entidades;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class HuespedService : IService<Huesped>
    {
        private readonly HuespedRepository repositorioHuesped;

        public HuespedService()
        {
            repositorioHuesped = new HuespedRepository(Archivos.ARC_HUESPED);
        }

        public string Guardar(Huesped entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... El huesped no puede ser nulo.");
                }

                return repositorioHuesped.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar el huesped: {ex.Message}";
            }
        }

        public List<Huesped> Consultar()
        {
            return repositorioHuesped.Consultar();
        }

        public string Modificar(Huesped entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... El huesped no puede ser nulo.");
                }

                return repositorioHuesped.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar el huesped: {ex.Message}";
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Error... El ID del huesped no puede ser menor o igual a cero.");
                }

                return repositorioHuesped.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar el huesped: {ex.Message}";
            }
        }

        public Huesped BuscarId(int id)
        {
            var huespedBuscado = Consultar().FirstOrDefault<Huesped>(x => x.Id == id);
            return huespedBuscado;
        }

        public List<Huesped> BuscarPorNombre(string nombre)
        {
            return Consultar().Where(h => h.Nombres.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}

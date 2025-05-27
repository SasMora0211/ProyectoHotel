using System;
using Entidades;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class RecepcionistaService : IService<Recepcionista>
    {
        private readonly RecepcionistaRepository repositorioRecepcionista;

        public RecepcionistaService()
        {
            repositorioRecepcionista = new RecepcionistaRepository(Archivos.ARC_RECEPCIONISTA);
        }

        public string Guardar(Recepcionista entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... El recepcionista no puede ser nulo.");
                }
                return repositorioRecepcionista.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar el recepcionista: {ex.Message}";
            }
        }

        public List<Recepcionista> Consultar()
        {
            return repositorioRecepcionista.Consultar();
        }

        public string Modificar(Recepcionista entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... El recepcionista no puede ser nulo.");
                }
                return repositorioRecepcionista.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar el recepcionista: {ex.Message}";
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Error... El ID del recepcionista no puede ser menor o igual a cero.");
                }

                return repositorioRecepcionista.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar el recepcionista: {ex.Message}";
            }
        }

        public Recepcionista BuscarId(int id)
        {
            var recepcionistaBuscado = Consultar().FirstOrDefault<Recepcionista>(x => x.Id == id);
            return recepcionistaBuscado;
        }
    }
}

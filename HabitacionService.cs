using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class HabitacionService : IService<Habitacion>
    {
        private readonly HabitacionRepository repositorioHabitacion;

        public HabitacionService()
        {
            repositorioHabitacion = new HabitacionRepository(Archivos.ARC_HABITACION);
        }

        public string Guardar(Habitacion entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... La habitacion no puede ser nula.");
                }
                return repositorioHabitacion.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar la habitacion: {ex.Message}";
            }
        }

        public List<Habitacion> Consultar()
        {
            return repositorioHabitacion.Consultar();
        }

        public string Modificar(Habitacion entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... La habitacion no puede ser nula.");
                }
                return repositorioHabitacion.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar la habitacion: {ex.Message}";
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Error... El ID de la habitacion no puede ser menor o igual a cero.");
                }
                return repositorioHabitacion.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar la habitacion: {ex.Message}";
            }
        }

        public Habitacion BuscarId(int id)
        {
            var habitacionBuscado = Consultar().FirstOrDefault<Habitacion>(x => x.Id == id);
            return habitacionBuscado;
        }
    }
}

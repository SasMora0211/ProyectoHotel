using System;
using Datos;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class ReservaService : IService<Reserva>
    {
        private readonly ReservaRepository repositorioReserva;

        public ReservaService()
        {
            repositorioReserva = new ReservaRepository(Archivos.ARC_RESERVA);
        }

        public string Guardar(Reserva entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new NullReferenceException("Error... La reserva no puede ser nula.");
                }
                return repositorioReserva.Guardar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al guardar la reserva: {ex.Message}";
            }
        }

        public string GuardarReserva(Reserva reserva)
        {
            if (reserva == null)
                return "La reserva no puede ser nula.";

            reserva.CostoTotal = reserva.CalcularCosto();
            return Guardar(reserva);
        }

        public List<Reserva> Consultar(int idHuesped)
        {
            return Consultar().Where(r => r.Huesped != null && r.Huesped.Id == idHuesped).ToList();
        }

        private IEnumerable<Reserva> Consultar()
        {
            throw new NotImplementedException();
        }

        public string Modificar(Reserva entity)
        {
            try
            {
                if (entity == null)
                    throw new NullReferenceException("Error... La reserva no puede ser nula.");
                return repositorioReserva.Modificar(entity);
            }
            catch (Exception ex)
            {
                return $"Error al modificar la reserva: {ex.Message}";
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException("Error... El ID de la reserva no puede ser menor o igual a cero.");
                return repositorioReserva.Eliminar(id);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar la reserva: {ex.Message}";
            }
        }

        public Reserva BuscarId(int id)
        {
            var reservaBuscado = Consultar().FirstOrDefault<Reserva>(x => x.Id == id);
            return reservaBuscado;
        }

        List<Reserva> IService<Reserva>.Consultar()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datos
{
    public class ReservaRepository : FileRepository<Reserva>
    {
        public HuespedRepository huespedRepository;
        public HabitacionRepository habitacionRepository;

        public ReservaRepository(string ruta) : base(ruta)
        {
            huespedRepository = new HuespedRepository(Archivos.ARC_HUESPED);
            habitacionRepository = new HabitacionRepository(Archivos.ARC_HABITACION);
        }

        public override List<Reserva> Consultar()
        {
            try
            {
                List<Reserva> listaReserva = new List<Reserva>();
                if (!File.Exists(ruta))
                {
                    StreamReader lector = new StreamReader(ruta);
                    while (!lector.EndOfStream)
                    {
                        listaReserva.Add(Mappear(lector.ReadLine()));
                    }
                    lector.Close();
                }
                return listaReserva;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override Reserva Mappear(string datos)
        {
            Reserva reserva = new Reserva();
            string[] partes = datos.Split(';');

            reserva.Id = int.Parse(partes[0]);

            int IdHuesped = int.Parse(partes[1]);
            Huesped huesped = huespedRepository.Consultar().FirstOrDefault(e => e.Id == IdHuesped);
            

            int IdHabitacion = int.Parse(partes[2]);
            Habitacion habitacion = habitacionRepository.Consultar().FirstOrDefault(e => e.Id == IdHabitacion);

            reserva.FechaIngreso = DateTime.Parse(partes[10]);
            reserva.FechaSalida = DateTime.Parse(partes[11]);
            reserva.CostoTotal = int.Parse(partes[12]);
            return reserva;
        }
    }
}

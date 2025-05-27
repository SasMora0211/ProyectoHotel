using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Reserva
    {
        public int Id { get; set; }
        public Huesped Huesped { get; set; }
        public Habitacion Habitacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public int CostoTotal { get; set; }

        public int CalcularCosto()
        {
            int noches = (FechaSalida - FechaIngreso).Days;
            if (Habitacion != null)
                return (int)(noches * Habitacion.PrecioPorNoche);
            return 0;
        }

        public int CalcularNoches()
        {
            return (FechaSalida - FechaIngreso).Days;
        }

        
    }
}

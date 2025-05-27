using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum CategoriaHabitacion
    {
        Economica,
        Estandar,
        Suite
    }

    public class Habitacion
    {
        public int Id { get; set; }
        public CategoriaHabitacion Categoria { get; set; }
        public decimal PrecioPorNoche { get; set; }
    }
}

using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datos
{
    public class HabitacionRepository : FileRepository<Habitacion>
    {
        public HabitacionRepository(string ruta) : base(ruta)
        {
        }

        public override List<Habitacion> Consultar()
        {
            try
            {
                List<Habitacion> listaHabitaciones = new List<Habitacion>();
                if (!File.Exists(ruta))
                {
                    StreamReader lector = new StreamReader(ruta);
                    while (!lector.EndOfStream)
                    {
                        listaHabitaciones.Add(Mappear(lector.ReadLine()));
                    }
                    lector.Close();
                }
                return listaHabitaciones;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override Habitacion Mappear(string datos)
        {
            Habitacion habitacion = new Habitacion();
            string[] partes = datos.Split(';');

            habitacion.Id = int.Parse(partes[0]);
            habitacion.Categoria = (CategoriaHabitacion)Enum.Parse(typeof(CategoriaHabitacion), partes[1]);
            habitacion.PrecioPorNoche = decimal.Parse(partes[2]);
            return habitacion;
        }
    }
}

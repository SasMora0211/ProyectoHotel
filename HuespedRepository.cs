using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;


namespace Datos
{
    public class HuespedRepository : FileRepository<Huesped>
    {
        public HuespedRepository(string ruta) : base(ruta)
        {
        }

        public override List<Huesped> Consultar()
        {
            var listaHuespedes = new List<Huesped>();
            string cadena = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT Id, Nombres, Apellidos, Telefono, Correo, FechaRegistro FROM Huespedes";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var huesped = new Huesped
                        {
                            Id = reader.GetInt32(0),
                            Nombres = reader.GetString(1),
                            Apellidos = reader.GetString(2),
                            Telefono = (uint)reader.GetInt32(3),
                            Correo = reader.GetString(4),
                            FechaRegistro = reader.GetDateTime(5)
                        };
                        listaHuespedes.Add(huesped);
                    }
                }
            }
            return listaHuespedes;
        }

        public override Huesped Mappear(string datos)
        {
            Huesped huesped = new Huesped();
            string[] partes = datos.Split(';');

            huesped.Id = int.Parse(partes[0]);
            huesped.Nombres = partes[1];
            huesped.Apellidos = partes[2];
            huesped.Telefono = uint.Parse(partes[3]);
            huesped.Correo = partes[4];
            huesped.FechaRegistro = DateTime.Parse(partes[5]);
            return huesped;
        }

        private void MostrarReservasDeHuesped(int idHuesped)
        {
            var reservas = reservaService.ConsultarPorHuesped(idHuesped);
            dataGridViewReservas.DataSource = reservas;
        }
    }
}


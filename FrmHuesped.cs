using System;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion
{
    public partial class FrmHuesped : Form
    {
        private HuespedService huespedService = new HuespedService();
        private ReservaService reservaService = new ReservaService();

        public FrmHuesped()
        {
            InitializeComponent();
            CargarHuespedes();
        }

        private void CargarHuespedes()
        {
            var lista = huespedService.Consultar();
            dataGridViewHuespedes.AutoGenerateColumns = false;
            dataGridViewHuespedes.Columns.Clear();

            var colNombre = new DataGridViewTextBoxColumn();
            colNombre.DataPropertyName = "Nombres";
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "Nombres";
            dataGridViewHuespedes.Columns.Add(colNombre);

            dataGridViewHuespedes.DataSource = lista;
        }

        private void dataGridViewHuespedes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewHuespedes.CurrentRow != null)
            {
                var huesped = (Huesped)dataGridViewHuespedes.CurrentRow.DataBoundItem;
                DatosHuespedes.Text = $"ID: {huesped.Id}\n" +
                                      $"Nombre: {huesped.Nombres}\n" +
                                      $"Apellidos: {huesped.Apellidos}\n" +
                                      $"Teléfono: {huesped.Telefono}\n" +
                                      $"Correo: {huesped.Correo}\n" +
                                      $"Fecha de Ingreso: {huesped.FechaRegistro:dd/MM/yyyy}";

                MostrarReservasDeHuesped(huesped.Id);
            }
        }

        private void MostrarReservasDeHuesped(int idHuesped)
        {
            var reservas = reservaService.Consultar(idHuesped);
            dataGridViewReservas.DataSource = reservas;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
        }
    }
}

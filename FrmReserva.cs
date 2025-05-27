using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmReserva : Form
    {
        public FrmReserva()
        {
            InitializeComponent();
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva
            {
                FechaIngreso = dateTimePickerIngreso.Value,
                FechaSalida = dateTimePickerSalida.Value,
                Habitacion = (Habitacion)comboBoxHabitaciones.SelectedItem
            };
            txtCosto.Text = reserva.CalcularCosto().ToString("C");
        }
    }
}

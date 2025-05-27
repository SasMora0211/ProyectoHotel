using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion
{
    public partial class CalcularCosto : Form
    {
        private System.Windows.Forms.ComboBox comboBoxHabitaciones;
        private System.Windows.Forms.DateTimePicker dateTimePickerIngreso;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalida;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnCalcular;

        public CalcularCosto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Asegúrate de que estos controles existen en el diseñador
            var habitacion = (Habitacion)comboBoxHabitaciones.SelectedItem;
            DateTime fechaIngreso = dateTimePickerIngreso.Value;
            DateTime fechaSalida = dateTimePickerSalida.Value;

            Reserva reserva = new Reserva
            {
                Habitacion = habitacion,
                FechaIngreso = fechaIngreso,
                FechaSalida = fechaSalida
            };

            int costo = reserva.CalcularCosto();
            txtCosto.Text = costo.ToString("C");
        }
    }
}


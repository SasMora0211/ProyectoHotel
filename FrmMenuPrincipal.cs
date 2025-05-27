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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); // Por ejemplo, cerrar el menú principal
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnHuesped_Click(object sender, EventArgs e)
        {
            FrmHuesped frm = new FrmHuesped();
            frm.ShowDialog();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            FrmReserva frm = new FrmReserva();
            frm.ShowDialog();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            FrmDatos frm = new FrmDatos();
            frm.ShowDialog();
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e) {
            public int CalcularCosto()
        {
            int noches = (FechaSalida - FechaIngreso).Days;
            if (Habitacion != null)
                return (int)(noches * Habitacion.PrecioPorNoche);
            return 0;
        }
        
    }    
}


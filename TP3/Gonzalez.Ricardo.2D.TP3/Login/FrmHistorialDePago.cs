using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesTp3;

namespace FormsTP3
{
    public partial class FrmHistorialDePago : Form
    {
        private Jugador usuario1;
        private Equipo equipo;

        public FrmHistorialDePago()
        {
            InitializeComponent();
        }

        public FrmHistorialDePago(Jugador usuario1):this()
        {
            this.usuario1 = usuario1;
        }

        public FrmHistorialDePago(Equipo equipo) : this()
        {
            this.equipo = equipo;
        }

        private void FrmListaRegistroPago_Load(object sender, EventArgs e)
        {
            if(equipo is not null)
            {
                rtbListadeRegistros.Text = equipo.HistorialDePago;

            }
            else
            {
                rtbListadeRegistros.Text = usuario1.HistorialDePago;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}

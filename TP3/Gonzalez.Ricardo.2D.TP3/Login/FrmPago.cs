using System;
using System.Windows.Forms;
using EntidadesTp3;

namespace FormsTP3
{
    public partial class FrmPago : Form
    {
        private Jugador jugador;
        private Equipo equipo;

        public FrmPago()
        {
            InitializeComponent();
        }

        public FrmPago(Jugador usuario) : this()
        {
            this.jugador = usuario;
        }

        public FrmPago(Equipo equipo) : this()
        {
            this.equipo = equipo;
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            try
            {

                if (jugador is not null)
                {

                    lblNombre.Text = jugador.Nombre;
                }
                if (equipo is not null)
                {
                    lblNombre.Text = equipo.NombreEquipo;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(txtbMonto.Text))
                {
                    if (jugador is not null)
                    {
                        jugador.PagoMensual(txtbMonto.Text);

                    }
                    if (equipo is not null)
                    {
                        equipo.PagoMensual(txtbMonto.Text);
                    }

                }
                else
                {
                    MessageBox.Show("Campos vacios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
        }
    }
}

using System;
using System.Windows.Forms;
using EntidadesTp3;

namespace FormsTP4
{
    public partial class FrmPago : Form
    {
        private DelegadoPagoMensual delegado;

        public FrmPago()
        {
            InitializeComponent();
        }
   
        public FrmPago(DelegadoPagoMensual delegado) : this()
        {
            this.delegado = delegado;
        }


        private void FrmPago_Load(object sender, EventArgs e)
        {
            try
            {
                ///////////

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

                    delegado.Invoke(txtbMonto.Text);

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

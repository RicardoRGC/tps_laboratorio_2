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

namespace FormsTP4
{
    public partial class FrmHistorialDePago : Form
    {
    
        private Func<string> funcDelegado;

        public FrmHistorialDePago()
        {
            InitializeComponent();
        }

        public FrmHistorialDePago(Func<string> funcDelegado):this()
        {
            this.funcDelegado = funcDelegado;
        }

        private void FrmListaRegistroPago_Load(object sender, EventArgs e)
        {
  
                rtbListadeRegistros.Text = funcDelegado.Invoke();

        }

       }
}

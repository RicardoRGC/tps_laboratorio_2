using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason==CloseReason.UserClosing)
            {
                DialogResult resultado= MessageBox.Show("¿Seguro de querer salir?", "Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if(resultado!=DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            foreach(Control item in this.Controls)
            {
               if(item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
            }
        }
    }
}

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

namespace MiCalculadora
{
    public partial class MiCalculadora : Form
    {
        public MiCalculadora()
        {
            InitializeComponent();
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
            cmbOperador.SelectedIndex = -1;

            foreach (Control item in this.Controls)
            {
               if(item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                    
                }
            }
            
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
           
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
           

        }

        private void btOperar_Click(object sender, EventArgs e)
        {
            


           



            Operando num1 = new Operando(txtNumero1.Text);
            Operando num2 = new Operando(txtNumero2.Text);
          
            
            double Resultado = Calculadora.Operar(num1,num2,char.Parse(cmbOperador.Text));

            lblResultado.Text = Resultado.ToString();

        }
    }
}

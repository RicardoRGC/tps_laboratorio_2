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
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
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
            Limpiar();
            
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
           
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add(" ");
            this.cmbOperador.SelectedIndex = 4;

        }

        private void btOperar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumero1.Text) && !string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);

                lblResultado.Text = resultado.ToString();

                if(cmbOperador.Text==" ")
                {

                lstOperaciones.Items.Add($"{txtNumero1.Text} + {txtNumero2.Text} = {lblResultado.Text}");
                }
                else
                {

                lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {lblResultado.Text}");
                }
            }
            else
            {
                MessageBox.Show($"se deben completar los campos","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Limpiar()
        {

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
            cmbOperador.SelectedIndex = 4;
            lblResultado.Text = String.Empty;
                    ((TextBox)item).Text = string.Empty;

                }
            }
        }
        public static double Operar(string numero1, string numero2, string operador)
        {

            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            double resultado = Calculadora.Operar(num1, num2, char.Parse(operador));

            
           
            return resultado;
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblResultado.Text))
                {
                string resultado= Operando.DecimalBinario(lblResultado.Text);

                  lblResultado.Text = resultado;
                lstOperaciones.Items.Add($"Binario {resultado}");
                 }
            else
            {
                MessageBox.Show($"Se debe tener un Resultado para realizar la Operacion"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


             
           
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblResultado.Text))
            {
                string resultado = Operando.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = resultado;
                lstOperaciones.Items.Add($"Decimal {resultado}");
            }
            else
            {
                MessageBox.Show($"Se debe tener un Resultado para realizar la Operacion"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || e.KeyChar == '-'|| e.KeyChar == '.' || e.KeyChar == ',')
            {
            txtNumero1.ForeColor = Color.Black;

            }
            else
            {
                txtNumero1.ForeColor = Color.Red;

                if (char.IsLetter(e.KeyChar))
                {
                   
                    txtNumero1.ForeColor= Color.Red;
                }

            }
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == ',')
            {
                txtNumero2.ForeColor = Color.Black;

            }
            else
            {
                txtNumero2.ForeColor = Color.Red;

                if (char.IsLetter(e.KeyChar))
                {

                    txtNumero2.ForeColor = Color.Red;
                }

            }
        }
    }
}

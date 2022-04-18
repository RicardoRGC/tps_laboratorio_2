using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades1;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// cierrra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// cierrra el formulario 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// limpia el formulario, deja espacios en blanco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            
        }
        /// <summary>
        /// carga el cmb operardor por defecto 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
           
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add(" ");
            this.cmbOperador.SelectedIndex = 4;

        }
        /// <summary>
        /// valida que los espacios no esten en blanco y llama al metodo operar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        ///deja en blanco lbl y textbox
        /// </summary>
        private void Limpiar()
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
        /// <summary>
        /// instancia los 2 numeros recibidos y se los pasa por parametroa la funcion operar.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>retorna el resultado de la operacion</returns>
        public static double Operar(string numero1, string numero2, string operador)
        {

            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            double resultado = Calculadora.Operar(num1, num2, char.Parse(operador));

            
           
            return resultado;
        }
        /// <summary>
        /// valida que lbl no este vacio y llama a la funcion decimalbinario
        /// muestra los resultados de las operaciones 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// /// valida que lbl no este vacio y llama a la funcion binarioDecimal
        /// muestra los resultados de las operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// valida las teclas permitidas, al ingresar letras se pone en rojo y se bloquea,
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || e.KeyChar == '-'|| e.KeyChar == ',')
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
        /// <summary>
        ///  valida las teclas permitidas, al ingresar letras se pone en rojo y se bloquea,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

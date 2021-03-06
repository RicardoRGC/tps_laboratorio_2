using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EntidadesArchivos;
using EntidadesExcepciones;
using EntidadesTp3;

namespace FormsTP3
{
    public partial class FrmInicio : Form
    {

        public FrmInicio()
        {
            InitializeComponent();

        }

        private void AgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (LigaFutbol<Equipo>.listaLigaStatica.Count != 0)
                {
                    FrmMenuAbm menuListado = new FrmMenuAbm(true);
                    menuListado.ShowDialog();
                }
                else
                {

                    MessageBox.Show("Debe Agregar Un Equipo.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            try
            {
                Usuario.LastLegajo = int.Parse(Archivo.LeerLastId("LastId"));
                Equipo.LasId = int.Parse(Archivo.LeerLastId("LastId"));

                btnGuardar.Enabled = false;

            }
            catch (ArchivoInvalidoIdException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            try
            {

            FrmMenuAbm menuListado = new FrmMenuAbm(false);

            menuListado.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            try
            {

            FrmRegistroDePagos gestionarPagos = new FrmRegistroDePagos();
            gestionarPagos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseSerializadora<List<Equipo>>.EscribirT(LigaFutbol<Equipo>.listaLigaStatica, "ListaEquipo");
                ClaseSerializadora<List<Usuario>>.EscribirT(LigaFutbol<Usuario>.listaLigaStatica, "ListaUsuarios");
            }
            catch (ArchivoInvalidoException ex)
            {

                MessageBox.Show(ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void CargaDeDatos()
        {
            try
            {

            LigaFutbol<Equipo>.listaLigaStatica.AddRange(ClaseSerializadora<List<Equipo>>.LeerListaT("ListaEquipo"));
            LigaFutbol<Usuario>.listaLigaStatica.AddRange(ClaseSerializadora<List<Usuario>>.LeerListaT("ListaUsuarios"));

            EntidadesTp3.RegistroDePagos.AgregarLIsta(LigaFutbol<Usuario>.listaLigaStatica);
            EntidadesTp3.RegistroDePagos.AgregarLIsta(LigaFutbol<Equipo>.listaLigaStatica);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                CargaDeDatos();
  
                btnCargarDatos.Enabled = false;
                btnGuardar.Enabled = true;

            }
            catch (ArchivoInvalidoException ex)
            {

                MessageBox.Show(ex.Message);
            }
  
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {


                DialogResult resultado = MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }

            }
        }
    }
}

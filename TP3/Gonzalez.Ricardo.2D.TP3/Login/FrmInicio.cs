using EntidadesTp3;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EntidadesArchivos;
using EntidadesExcepciones;

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
                    MessageBox.Show("Primero tiene q registar un equipo.");
                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            try
            {
               Usuario.LastLegajo =int.Parse( Archivo.LeerLastId("LastId"));
                Equipo.LasId = int.Parse(Archivo.LeerLastId("LastIdEquipo"));

            }
            catch (ArchivoInvalidoIdException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            FrmMenuAbm menuListado = new FrmMenuAbm(false);

            menuListado.ShowDialog();
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            RegistroDePagos gestionarPagos = new RegistroDePagos();
            gestionarPagos.ShowDialog();

        }

        private void txtguardar_Click(object sender, EventArgs e)
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

               
              
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                LigaFutbol<Usuario>.listaLigaStatica.AddRange( ClaseSerializadora<List<Usuario>>.LeerListaT("ListaUsuarios"));
                LigaFutbol<Equipo>.listaLigaStatica.AddRange(ClaseSerializadora<List<Equipo>>.LeerListaT("ListaEquipo"));

                EntidadesTp3.RegistroDePagos.AgregarLIsta(LigaFutbol<Usuario>.listaLigaStatica);
                EntidadesTp3.RegistroDePagos.AgregarLIsta(LigaFutbol<Equipo>.listaLigaStatica);

                btnCargarDatos.Enabled = false;

            }
            catch (ArchivoInvalidoException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

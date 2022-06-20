using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesArchivos;
using EntidadesExcepciones;
using EntidadesTp3;

namespace FormsTP4
{

    public partial class FrmInicio : Form
    {
    
        DelegadoPrint print = (texto) => MessageBox.Show(texto);

        public FrmInicio()
        {
            InitializeComponent();
           
        }

        private void AgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMenuAbm menuListado = new FrmMenuAbm(true);
                menuListado.ShowDialog();

            }
            catch (Exception ex)
            {

                print(ex.Message);
            }


        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            try
            {
             
                EquipoDao.eventoNotificarError += NotificarLblErrorEvento;                
                btnGuardar.Enabled = true;
                CargaDeDatos();

                Task tarea = Task.Run(() => RegistroDePagos.AgregarLIsta(EquipoDao.Leer()));
                                
                tarea.Wait();

            }
            catch (TaskCanceledException ex)
            {
                print(ex.Message);
            }
            catch (ArchivoInvalidoIdException ex)
            {

                btnAgregarEquipo.Enabled = false;
                btnGuardar.Enabled = false;
                btnUsuarios.Enabled = false;
                btnRegistros.Enabled = false;

                print(ex.Message);

            }
            catch (Exception ex)
            {
                print(ex.Message);
                btnAgregarEquipo.Enabled = false;
                btnGuardar.Enabled = false;
                btnUsuarios.Enabled = false;
                btnRegistros.Enabled = false;
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
                print(ex.Message);
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
                print(ex.Message);
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

                print(ex.Message);
            }

            catch (Exception ex)
            {
                print(ex.Message);
            }


        }
        public void CargaDeDatos()
        {
            try
            {

                LigaFutbol<Usuario>.listaLigaStatica.AddRange(ClaseSerializadora<List<Usuario>>.LeerListaT("ListaUsuarios"));

                EntidadesTp3.RegistroDePagos.AgregarLIsta(LigaFutbol<Usuario>.listaLigaStatica);

            }
            catch (Exception ex)
            {
                print(ex.Message);
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
        private void NotificarLblErrorEvento()
        {
            if (this.InvokeRequired)
            {
                Action callback = new Action(NotificarLblErrorEvento);

            
                this.BeginInvoke(callback);
            }
            else
            {
            lblNotificacionError.Visible = true;
            lblNotificacionError.Text = "Por favor solucione el Problema\n" +
                    " y vuelva a iniciar el Programa";
            }
        }

    }
}

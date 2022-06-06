using System;
using System.Windows.Forms;
using EntidadesTp3;

namespace FormsTP3
{
    public partial class FrmMenuAbm : Form
    {
        private bool sonUsuarios;

        public FrmMenuAbm()
        {
            InitializeComponent();
        }



        public FrmMenuAbm(bool sonUsuarios) : this()
        {
            this.sonUsuarios = sonUsuarios;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregar agregarUsuario = new FrmAgregar(sonUsuarios);

                agregarUsuario.ShowDialog();

                RefrescarBiblioteca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MenuListado_Load(object sender, EventArgs e)
        {
            try
            {

                if (sonUsuarios)
                {
                    cmbFiltrarUsuarios.Items.Add("Todos");
                    cmbFiltrarUsuarios.Items.Add("Jugador");
                    cmbFiltrarUsuarios.Items.Add("DirectorTecnico");
                    cmbFiltrarUsuarios.Items.Add("Arbitro");


                    dgvListado.DataSource = LigaFutbol<Usuario>.listaLigaStatica;
                  

                    DataGridViewColumn dataGridViewColumn = dgvListado.Columns[5];
                    dataGridViewColumn.Visible = false;

                    cmbFiltrarUsuarios.SelectedIndex = 0;

                }
                else
                {
                    dgvListado.DataSource = LigaFutbol<Equipo>.listaLigaStatica;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvListado.SelectedRows.Count > 0)
                {
                    if (sonUsuarios)
                    {
                        Usuario usuario = (Usuario)dgvListado.CurrentRow.DataBoundItem;

                        if (LigaFutbol<Usuario>.listaLigaStatica - usuario)
                        {
                            RefrescarBiblioteca();
                            MessageBox.Show("se elimino Correctamente");
                        }

                    }
                    else
                    {
                        Equipo equipo = (Equipo)dgvListado.CurrentRow.DataBoundItem;

                        if (LigaFutbol<Equipo>.listaLigaStatica - equipo)
                        {
                            RefrescarBiblioteca();
                            MessageBox.Show("se elimino Correctamente");
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RefrescarBiblioteca()

        {
            try
            {
            dgvListado.DataSource = null;

                if (sonUsuarios)
                {
                    dgvListado.DataSource = LigaFutbol<Usuario>.listaLigaStatica;

                }
                else
                {
                    dgvListado.DataSource = LigaFutbol<Equipo>.listaLigaStatica;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbFiltrarUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                dgvListado.DataSource = null;


                switch (cmbFiltrarUsuarios.SelectedIndex)
                {
                    case 0:
                        dgvListado.DataSource = null;

                        dgvListado.DataSource = LigaFutbol<Usuario>.listaLigaStatica;



                        break;
                    case 1:
                        dgvListado.DataSource = null;
                        dgvListado.DataSource = Usuario.ListarPorJugadores();
                        DataGridViewColumn Column = dgvListado.Columns[0];
                        DataGridViewColumn Column1 = dgvListado.Columns[1];
                        DataGridViewColumn Column2 = dgvListado.Columns[2];
                        // Column.Visible = false;
                        Column2.Visible = false;
                        Column1.Visible = false;
                        break;
                    case 2:
                        dgvListado.DataSource = null;
                        dgvListado.DataSource = Usuario.ListarPorDirectorTec();
                        break;
                    case 3:
                        dgvListado.DataSource = null;
                        dgvListado.DataSource = Usuario.ListarPorArbitro();
                        break;


                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvListado.SelectedRows.Count > 0)
                {
                    if (sonUsuarios)
                    {
                        Usuario usuario = (Usuario)dgvListado.CurrentRow.DataBoundItem;

                        FrmAgregar agregarUsuario = new FrmAgregar(sonUsuarios, usuario);

                        agregarUsuario.ShowDialog();

                    }
                    else
                    {
                        Equipo equipo = (Equipo)dgvListado.CurrentRow.DataBoundItem;

                        FrmAgregar agregarEquipo = new FrmAgregar(sonUsuarios, equipo);


                        agregarEquipo.ShowDialog();


                    }


                }
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
    }
}

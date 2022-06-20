using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesTp3;

namespace FormsTP4
{
   
    public partial class FrmMenuAbm : Form
    {
        private bool sonUsuarios;
        private CancellationTokenSource cts;

        public FrmMenuAbm()
        {
            InitializeComponent();
            cts = new CancellationTokenSource();
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
                    Task tarea = Task.Run(() => {

                        RefrescarBiblioteca();
                    });


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

                        if (EquipoDao.Eliminar(equipo.Id) && RegistroDePagos.EliminarUsuario(equipo.Id))
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
                if (this.InvokeRequired)
                {
                    Action callback = new Action(RefrescarBiblioteca);


                    this.BeginInvoke(callback);
                }
                else
                {

                    dgvListado.DataSource = null;

                    if (sonUsuarios)
                    {
                        dgvListado.DataSource = LigaFutbol<Usuario>.listaLigaStatica;

                    }
                    else
                    {
                        dgvListado.DataSource = EquipoDao.Leer();

                    }
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

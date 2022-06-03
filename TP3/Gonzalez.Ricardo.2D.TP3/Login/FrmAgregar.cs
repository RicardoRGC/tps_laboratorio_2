using System;
using System.Windows.Forms;
using EntidadesArchivos;
using EntidadesExcepciones;
using EntidadesTp3;

namespace FormsTP3
{
    public partial class FrmAgregar : Form
    {
        private bool sonUsuarios;
        private Usuario usuario;
        private Equipo equipo1;

        public FrmAgregar()
        {
            InitializeComponent();

        }

        public FrmAgregar(bool sonUsuarios) : this()
        {
            this.sonUsuarios = sonUsuarios;
        }

        public FrmAgregar(bool sonUsuarios, Usuario usuario) : this(sonUsuarios)
        {
            this.usuario = usuario;
            this.btnAgregar.Text = "Modificar";

        }
        public FrmAgregar(bool sonUsuarios, Equipo equipo) : this(sonUsuarios)
        {
            this.equipo1 = equipo;
            this.btnAgregar.Text = "Modificar";

        }

        private void RegistrarClick(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtbApellido.Text)
                && !string.IsNullOrWhiteSpace(txtbNombre.Text)
                && !string.IsNullOrWhiteSpace(txtbDni.Text)
                && !string.IsNullOrWhiteSpace(txtbEdad.Text))
                {
                    if (btnAgregar.Text == "Modificar")
                    {
                        if (sonUsuarios)
                        {
                            Usuario.ModificarUsuario(usuario, txtbApellido.Text, txtbNombre.Text, txtbDni.Text, txtbEdad.Text, cmbEquipo.Text);
                        }
                        else
                        {
                            equipo1.NombreEquipo = txtbNombre.Text;
                        }
                    }
                    else
                    {                        
                        if (sonUsuarios)
                        {
                           if( Usuario.AgregarUsuario(cmbTipoUsuario.Text,txtbApellido.Text,txtbNombre.Text,txtbDni.Text,txtbEdad.Text,cmbEquipo.Text))
                            {
                                MessageBox.Show("agregado correctamente");
                            }

                        }
                        else
                        {
                            if (Equipo.AgregarEquipo(txtbNombre.Text))
                            {
                                MessageBox.Show("agregado correctamente");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Campos vacios");
                }
            }
            catch (DatoInvalidoExeptionEquipo ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (DatoInvalidoExceptionUsuario ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(DatoInvalidoexceptionModificarUsuario ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            if (sonUsuarios)
            {

                cmbTipoUsuario.Items.Add("Jugador");
                cmbTipoUsuario.Items.Add("DirectorTecnico");
                cmbTipoUsuario.Items.Add("Arbitro");
                foreach (Equipo item in LigaFutbol<Equipo>.listaLigaStatica)
                {
                    cmbEquipo.Items.Add(item.NombreEquipo);
                }


                if (btnAgregar.Text == "Modificar")
                {
                    if (sonUsuarios)
                    {
                        txtbApellido.Text = usuario.Apellido;
                        txtbNombre.Text = usuario.Nombre;
                        txtbDni.Text = usuario.Dni.ToString();
                        txtbEdad.Text = usuario.Edad.ToString();
                        cmbEquipo.Text = Equipo.BuscarEquipo(usuario.IdEquipo);

                        if (usuario is Jugador)
                        {
                            cmbTipoUsuario.Text = "Jugador";
                        }
                        else
                        {
                            if (usuario is DirectorTecnico)
                            {
                                cmbTipoUsuario.Text = "DirectorTecnico";
                            }
                            else
                            {
                                if (usuario is Arbitro)
                                {
                                    cmbTipoUsuario.Text = "Arbitro";
                                    cmbEquipo.Visible = false;
                                }
                            }
                        }

                    }
                    else
                    {
                        txtbNombre.Text = equipo1.NombreEquipo;

                    }


                    cmbTipoUsuario.Enabled = false;


                }

            }
            else
            {
                txtbDni.Visible = false;
                txtbEdad.Visible = false;

                txtbApellido.Visible = false;
                cmbEquipo.Visible = false;
                cmbTipoUsuario.Visible = false;
                label1.Visible = true;

            }
        }
    }
}

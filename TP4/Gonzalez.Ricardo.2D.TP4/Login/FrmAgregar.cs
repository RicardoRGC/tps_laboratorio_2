using System;
using System.Windows.Forms;
using EntidadesExcepciones;
using EntidadesTp3;
using EntidadesArchivos;

namespace FormsTP4
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
            try
            {
                this.sonUsuarios = sonUsuarios;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FrmAgregar(bool sonUsuarios, Usuario usuario) : this(sonUsuarios)
        {
            try
            {
                this.usuario = usuario;
                this.btnAgregar.Text = "Modificar";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public FrmAgregar(bool sonUsuarios, Equipo equipo) : this(sonUsuarios)
        {
            try
            {

                this.equipo1 = equipo;
                this.btnAgregar.Text = "Modificar";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                            EquipoDao.Modificar(equipo1, txtbNombre.Text);
                        }
                    }
                    else
                    {
                        if (sonUsuarios)
                        {
                            if (Usuario.AgregarUsuario(cmbTipoUsuario.Text, txtbApellido.Text, txtbNombre.Text, txtbDni.Text, txtbEdad.Text, cmbEquipo.Text))
                            {
                                MessageBox.Show("agregado correctamente");
                                DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Error al guardar el Usuario");
                            }

                        }
                        else
                        {
                            if (Equipo.AgregarEquipo(txtbNombre.Text))
                            {
                                MessageBox.Show("agregado correctamente");
                                DialogResult = DialogResult.OK;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Campos vacios");
                }
                EntidadesTp3.RegistroDePagos.AgregarLIsta(EquipoDao.Leer());
            }
            catch (DatoInvalidoExeptionEquipo ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (DatoInvalidoExceptionUsuario ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DatoInvalidoexceptionModificarUsuario ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (sonUsuarios)
                {

                    cmbTipoUsuario.Items.Add("Jugador");
                    cmbTipoUsuario.Items.Add("DirectorTecnico");
                    cmbTipoUsuario.Items.Add("Arbitro");


                    foreach (Equipo item in EquipoDao.Leer())
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
                            cmbTipoUsuario.Enabled = false;

                            if (usuario is Jugador)
                            {
                                cmbTipoUsuario.Text = "Jugador";
                                cmbEquipo.Text = usuario.IdEquipo.BuscarNombreEquipoPorId();

                                
                            }
                            else
                            {
                               
                                if (usuario is DirectorTecnico)
                                {
                                    cmbTipoUsuario.Text = "DirectorTecnico";
                                    cmbEquipo.Text = usuario.IdEquipo.BuscarNombreEquipoPorId();
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
                Usuario.LastLegajo = int.Parse(Archivo.LeerLastId("LastId"));
            }
            catch (NullReferenceException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoUsuario.Text == "Arbitro")
                {
                    cmbEquipo.Enabled = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

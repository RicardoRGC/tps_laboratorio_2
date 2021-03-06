using System;
using System.Windows.Forms;
using EntidadesExcepciones;
using EntidadesTp3;
namespace FormsTP3
{
    public partial class FrmRegistroDePagos : Form
    {
        private ListViewItem listItem;
        public FrmRegistroDePagos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroDePagos gestionarPago = RegistroDePagos.BuscarUsuario(txtbBuscar.Text);
                if (gestionarPago != null)
                {
                    CargarltvPagos(gestionarPago);
                }
                else
                {
                    CargarLtvListaDePagos();
                }

            }
            catch (ExcepcionRegistroDePagos ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }
        private void CargarltvPagos(EntidadesTp3.RegistroDePagos pago)
        {
            try
            {

                Jugador jugador = (Jugador)pago.Usuario1;
                Equipo equipo = (Equipo)pago.Equipo;
                this.ltvListaGestiones.Items.Clear();


                listItem = new ListViewItem(pago.IdGention.ToString());
                listItem.SubItems.Add(pago.Nombre);
                if (pago.Usuario1 is not null)
                {
                    listItem.SubItems.Add(jugador.MontoPagado.ToString());
                    if (jugador.FechaDePago1 != DateTime.MinValue)
                    {

                        listItem.SubItems.Add(jugador.FechaDePago1.ToString());
                    }
                }
                if (pago.Equipo is not null)
                {
                    listItem.SubItems.Add(equipo.MontoPagado.ToString());
                    if (equipo.FechaDePgo1 != DateTime.MinValue)
                    {

                        listItem.SubItems.Add(equipo.FechaDePgo1.ToString());
                    }
                }



                this.ltvListaGestiones.Items.Add(listItem);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarLtvListaDePagos()
        {
            try
            {
                this.ltvListaGestiones.Items.Clear();

                foreach (var item in LigaFutbol<EntidadesTp3.RegistroDePagos>.listaLigaStatica)
                {
                    Jugador jugador = (Jugador)item.Usuario1;
                    Equipo equipo = (Equipo)item.Equipo;


                    listItem = new ListViewItem(item.IdGention.ToString());
                    listItem.SubItems.Add(item.Nombre);
                    if (item.Usuario1 is not null)
                    {
                        listItem.SubItems.Add(jugador.MontoPagado.ToString());
                        if (jugador.FechaDePago1 != DateTime.MinValue)
                        {

                            listItem.SubItems.Add(jugador.FechaDePago1.ToString());
                        }
                    }
                    if (item.Equipo is not null)
                    {
                        listItem.SubItems.Add(equipo.MontoPagado.ToString());
                        if (equipo.FechaDePgo1 != DateTime.MinValue)
                        {

                            listItem.SubItems.Add(equipo.FechaDePgo1.ToString());
                        }
                    }



                    this.ltvListaGestiones.Items.Add(listItem);

                }

            }
            catch (Exception)
            {

                throw new ExcepcionRegistroDePagos("Fallo la carga de Ltv");
            }

        }
        private void FrmGestionarPagos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarLtvListaDePagos();

            }
            catch (ExcepcionRegistroDePagos ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            try
            {

                FrmPago frmPago;
                foreach (ListViewItem item in ltvListaGestiones.SelectedItems)
                {
                    RegistroDePagos gestionarPago;
                    gestionarPago = RegistroDePagos.BuscarUsuario(item.Text);

                    if (gestionarPago.Usuario1 is not null)
                    {

                        frmPago = new FrmPago(gestionarPago.Usuario1);

                        frmPago.ShowDialog();
                    }
                    else
                    {
                        frmPago = new FrmPago(gestionarPago.Equipo);

                        frmPago.ShowDialog();
                    }
                }
                CargarLtvListaDePagos();

            }
            catch (ExcepcionRegistroDePagos ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHistorialPagos_Click(object sender, EventArgs e)
        {
            FrmHistorialDePago frmListaRegistroPago;
            foreach (ListViewItem item in ltvListaGestiones.SelectedItems)
            {
                RegistroDePagos gestionarPago;
                gestionarPago = RegistroDePagos.BuscarUsuario(item.Text);

                if (gestionarPago.Usuario1 is not null)
                {

                      frmListaRegistroPago  = new FrmHistorialDePago(gestionarPago.Usuario1);
                  

                    frmListaRegistroPago.ShowDialog();
                }
                else
                {

                    frmListaRegistroPago = new FrmHistorialDePago(gestionarPago.Equipo);


                    frmListaRegistroPago.ShowDialog();
                }
            }

            
        }
    }
}

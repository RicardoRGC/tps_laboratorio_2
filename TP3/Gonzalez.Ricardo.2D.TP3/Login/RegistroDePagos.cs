using System;
using System.Windows.Forms;
using EntidadesTp3;

namespace FormsTP3
{
    public partial class RegistroDePagos : Form
    {
        private ListViewItem listItem;
        public RegistroDePagos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            EntidadesTp3.RegistroDePagos gestionarPago = EntidadesTp3.RegistroDePagos.BuscarUsuario(txtbBuscar.Text);

            if (gestionarPago != null)
            {
                CargarltvPagos(gestionarPago);
            }




        }
       private void CargarltvPagos(EntidadesTp3.RegistroDePagos pago)
        {
            Jugador jugador = (Jugador)pago.Usuario1;
            Equipo equipo = (Equipo)pago.Equipo;
            this.ltvListaGestiones.Items.Clear();


            listItem = new ListViewItem(pago.IdGention.ToString());
            listItem.SubItems.Add(pago.Nombre);
            if (pago.Usuario1 is not null)
            {
                listItem.SubItems.Add(jugador.MontoPagado.ToString());
                if (jugador.FechaDePgo1 != DateTime.MinValue)
                {

                    listItem.SubItems.Add(jugador.FechaDePgo1.ToString());
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
        private void CargarLtvListaDePagos()
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
                    if (jugador.FechaDePgo1 != DateTime.MinValue)
                    {

                        listItem.SubItems.Add(jugador.FechaDePgo1.ToString());
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
        private void FrmGestionarPagos_Load(object sender, EventArgs e)
        {
            CargarLtvListaDePagos();

        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            FrmPago frmPago;

            foreach (ListViewItem item in ltvListaGestiones.SelectedItems)
            {
                EntidadesTp3.RegistroDePagos gestionarPago;
                gestionarPago = EntidadesTp3.RegistroDePagos.BuscarUsuario(item.Text);

                if(gestionarPago.Usuario1 is not null)
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
    }
}

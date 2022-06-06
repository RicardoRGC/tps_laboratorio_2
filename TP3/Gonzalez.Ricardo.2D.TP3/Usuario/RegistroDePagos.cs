using System;
using System.Collections.Generic;

namespace EntidadesTp3
{
    public class RegistroDePagos
    {
        int idGention;
        string nombre;
        Jugador Usuario;
        Equipo equipo;

        public int IdGention { get => idGention; set => idGention = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Jugador Usuario1 { get => Usuario;  }
        public Equipo Equipo { get => equipo; }

        public RegistroDePagos(int idUsuario, string nombre, Jugador usuario)
        {
            idGention = idUsuario;
            this.nombre = nombre;
            Usuario = usuario;
        }
        public RegistroDePagos(int idUsuario, string nombre, Equipo equipo)
        {
            idGention = idUsuario;
            this.nombre = nombre;
            this.equipo = equipo;
        }
        /// <summary>
        /// Instancia un Registro de Jugador y lo Agrega a la lista Estatica
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="nombre"></param>
        /// <param name="usuario"></param>
        /// <returns>Retorna true si todo es Correcto</returns>
        public static bool AgregarRegistroDePago(int idUsuario, string nombre,Jugador usuario)
        {
            RegistroDePagos gestionarPago = new RegistroDePagos(idUsuario, nombre,usuario);

            if (gestionarPago is not null)
            {
                if (LigaFutbol<RegistroDePagos>.listaLigaStatica + gestionarPago)
                {
                    return true;
                }

            }
            return false;
        }
        /// <summary>
        /// Instancia un Registro de Jugador y lo Agrega a la lista Estatica
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="nombre"></param>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static bool AgregarGestionarPago(int idUsuario, string nombre,Equipo usuario)
        {
            RegistroDePagos gestionarPago = new RegistroDePagos(idUsuario, nombre,usuario);

            if (gestionarPago is not null)
            {
                if (LigaFutbol<RegistroDePagos>.listaLigaStatica + gestionarPago)
                {
                    return true;
                }

            }
            return false;
        }
        /// <summary>
        /// Busca por Nombre o Id
        /// </summary>
        /// <param name="dato"></param>
        /// <returns>Retorna el registro </returns>
        public static RegistroDePagos BuscarUsuario(string dato)
        {
            foreach (RegistroDePagos item in LigaFutbol<RegistroDePagos>.listaLigaStatica)
            {
                if (item.idGention.ToString() == dato || item.nombre == dato)
                {
                    return item;
                }

            }
            return null;
        }
        public static bool operator ==(List<RegistroDePagos> listaPagos, RegistroDePagos usuario)
        {

            foreach (RegistroDePagos item in listaPagos)
            {
                if (item.idGention == usuario.idGention)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// si el producto esta en la lista devuelve false
        /// </summary>
        /// <param name="listProductos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator !=(List<RegistroDePagos> listaPagos, RegistroDePagos usuario)
        {
            return !(listaPagos == usuario);
        }

        public static bool operator +(List<RegistroDePagos> listaUsuarios, RegistroDePagos usuario)
        {
            if (listaUsuarios != usuario)
            {
                listaUsuarios.Add(usuario);
                return true;
            }
            return false;
        }
        /// <summary>
        /// remueve un producto de la lista
        /// </summary>
        /// <param name="listProductos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator -(List<RegistroDePagos> listaUsuarios, RegistroDePagos usuario)
        {
            if (listaUsuarios == usuario)
            {
                listaUsuarios.Remove(usuario);
                return true;
            }
            return false;
        }
        public static bool AgregarLIsta(List<Equipo> liga)
        {
            if (liga is not null)
            {
                foreach (Equipo item in liga)
                {

                    if (RegistroDePagos.AgregarGestionarPago(item.Id, item.NombreEquipo,item))
                    {

                    }
                }
            }
            return false;
        }
        public static void AgregarLIsta(List<Usuario> liga)
        {
            if (liga is not null)
            {
                foreach (var item in liga)
                {
                    if (item is Jugador)
                    {
                        if (RegistroDePagos.AgregarRegistroDePago(item.Legajo, item.Nombre, (Jugador)item))
                        {

                        }

                    }
                }
            }

        }



    }

}

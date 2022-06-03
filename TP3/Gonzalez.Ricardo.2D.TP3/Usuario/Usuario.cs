using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using EntidadesExcepciones;
using EntidadesArchivos;
using System;

namespace EntidadesTp3

{
    [XmlInclude(typeof(Jugador))]
    [XmlInclude(typeof(DirectorTecnico))]
    [XmlInclude(typeof(Arbitro))]
    public abstract class Usuario
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        private int legajo;
        private static int lastLegajo;


        public Usuario()
        {

        }
        static Usuario()
        {
            lastLegajo = 1000;
        }

        public Usuario(string apellido, string nombre, int dni, int edad)
        {
            this.legajo = lastLegajo;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Dni = dni;
            this.Edad = edad;
            lastLegajo++;
            
        }




        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Legajo { get => legajo; set => legajo = value; }

        public virtual int IdEquipo { get; set; }
        public static int LastLegajo { get => lastLegajo; set => lastLegajo = value; }

        public static void ModificarUsuario(Usuario usuario,string apellido,string nombre,string dni,string edad,string equipo)
        {
            try
            {
                usuario.Apellido = apellido;
                usuario.Nombre = nombre;
                usuario.Dni = int.Parse(dni);
                usuario.Edad = int.Parse(edad);

                if (usuario is not Arbitro)
                    usuario.IdEquipo = Equipo.BuscarEquipo(equipo);
            }
            catch (Exception)
            {

                throw new DatoInvalidoexceptionModificarUsuario("Error al modificar");
            }


           
        }
        /// <summary>
        /// Agrega usuario.Tipo de usuario,apellido,nombre,dni,edad,equipo(nombre de equipo)
        /// </summary>
        /// <param name="tipoUsuario"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="dni"></param>
        /// <param name="edad"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        /// <exception cref="DatoInvalidoExceptionUsuario"></exception>
        public static bool AgregarUsuario(string tipoUsuario,string apellido,string nombre , string dni,string edad,string equipo )
        {
            Usuario usuarioNew = null;
            try
            {
                if (tipoUsuario == "Arbitro")
                {
                    usuarioNew = new Arbitro(apellido, nombre, int.Parse(dni), int.Parse(edad));

                }
                else
                {
                    if (tipoUsuario == "DirectorTecnico")
                    {
                        usuarioNew = new DirectorTecnico(apellido, nombre, int.Parse(dni), int.Parse(edad), Equipo.BuscarEquipo(equipo));

                    }
                    else
                    {
                        if (tipoUsuario == "Jugador")
                        {
                            usuarioNew = new Jugador(apellido, nombre, int.Parse(dni), int.Parse(edad), Equipo.BuscarEquipo(equipo));

                        }

                    }
                }
                if (LigaFutbol<Usuario>.listaLigaStatica + usuarioNew)
                {
                    Archivo.GuardarLastIdUsuario(Usuario.LastLegajo.ToString());

                    if (!RegistroDePagos.AgregarGestionarPago(usuarioNew.Legajo, usuarioNew.Nombre, (Jugador)usuarioNew))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw new DatoInvalidoExceptionUsuario("Error al Agregar Usuario");
            }
          
            return true;
        }
        /// <summary>
        /// busca usuario por dni , legajo o NOmbre
        /// </summary>
        /// <param name="dato"></param>
        /// <returns>el usuario si se encuentra, de lo contrario null</returns>
        public static Usuario BuscarUsuario(int dato)
        {
            foreach (Usuario item in LigaFutbol<Usuario>.listaLigaStatica)
            {
                if (item.legajo == dato || item.dni == dato )
                {
                    return item;
                }

            }
            return null;
        } public static Usuario BuscarUsuario(string dato)
        {
            foreach (Usuario item in LigaFutbol<Usuario>.listaLigaStatica)
            {
                if (item.Nombre==dato )
                {
                    return item;
                }

            }
            return null;
        }
        public virtual string Mostrar()
        {
            return (string)this;
        }
        public static explicit operator string(Usuario usuario)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {usuario.Nombre}");
            stringBuilder.AppendLine($"Apellido: {usuario.Apellido}");
            stringBuilder.AppendLine($"DNI: {usuario.Dni}");
            stringBuilder.AppendLine($"Edad: {usuario.Edad}");
            stringBuilder.AppendLine($"Legajo: {usuario.Legajo}");
            stringBuilder.AppendLine($"-----------");

            return stringBuilder.ToString();
        }
        //public static void CargarUsuarios()
        //{         

        //    Usuario usuario=new Jugador("gonzalez"," riky",3546002,31,1);
        //    Usuario usuario2=new Jugador("gonzalez"," riky",3546002,31,2);


        //    LigaFutbol<Usuario>.listaLigaStatica.Add(usuario);
        //    LigaFutbol<Usuario>.listaLigaStatica.Add(usuario2);
               
                       
        //}

        public static bool operator ==(List<Usuario> listaUsuarios, Usuario usuario)
        {

            foreach (Usuario item in listaUsuarios)
            {
                if (item.dni == usuario.dni)
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
        public static bool operator !=(List<Usuario> listaUsuarios, Usuario usuario)
        {
            return !(listaUsuarios == usuario);
        }

        public static bool operator +(List<Usuario> listaUsuarios, Usuario usuario)
        {
            if(usuario is null)
            {
                throw new DatoInvalidoExeptionEquipo("dato nulo");
            }
            if (listaUsuarios!= usuario)
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
        public static bool operator -(List<Usuario> listaUsuarios, Usuario usuario)
        {
            if (listaUsuarios == usuario)
            {
                listaUsuarios.Remove(usuario);
                return true;
            }
            return false;
        }
        public static List<Jugador> ListarPorJugadores()
        {
            List<Jugador> jugadores = new List<Jugador>();

            foreach (var item in LigaFutbol<Usuario>.listaLigaStatica)
            {

                if (item is Jugador)
                {
                    jugadores.Add((Jugador)item);

                }

            }

            return jugadores;
        }
        public static List<Arbitro> ListarPorArbitro()
        {
            List<Arbitro> suario = new List<Arbitro>();

            foreach (var item in LigaFutbol<Usuario>.listaLigaStatica)
            {

                if (item is Arbitro)
                {
                    suario.Add((Arbitro)item);

                }

            }

            return suario;
        }
        public static List<DirectorTecnico> ListarPorDirectorTec()
        {
            List<DirectorTecnico> usuario = new List<DirectorTecnico>();

            foreach (var item in LigaFutbol<Usuario>.listaLigaStatica)
            {

                if (item is DirectorTecnico)
                {
                    usuario.Add((DirectorTecnico)item);

                }

            }

            return usuario;
        }
    }
}

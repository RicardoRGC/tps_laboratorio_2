using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesTp3;
using EntidadesExcepciones;
using System;

namespace PruebasTp
{
    [TestClass]
    public class TestUsuario
    {
           
        [TestMethod]
        public void DeveriaRetornarDatoInvalidoExceptionUsuario()
        {           
            Assert.ThrowsException<DatoInvalidoExceptionUsuario>(() => Usuario.AgregarUsuario("riky", "gonza", "-1", "45", "-5", "4,4"));
        }
        [TestMethod]
        public void DeveraRetornarUsuarioJugador()
        {
            //arrange
            Equipo.AgregarEquipo("river");
            
            Usuario.AgregarUsuario("Jugador", "gonza", "nombre", "35460002", "35","river" );


            Assert.IsInstanceOfType(Usuario.BuscarUsuario("nombre"), typeof(Jugador));


        }
        [TestMethod]
        public void DeveriaRetornar()
        {
            Equipo.AgregarEquipo("river");

            Usuario.AgregarUsuario("Jugador", "gonza", "nombre", "35460002", "35", "river");

            Jugador jugador = (Jugador)Usuario.BuscarUsuario("nombre");

            jugador.PagoMensual("1500");

            RegistroDePagos registroDePagos = RegistroDePagos.BuscarUsuario("nombre");

            Assert.AreEqual(jugador, registroDePagos.Usuario1);

        }
        

    }
}

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


            Assert.IsInstanceOfType(Jugador.BuscarUsuario("nombre"), typeof(Jugador));


        }

    }
}

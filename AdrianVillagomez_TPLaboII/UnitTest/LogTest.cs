using Entidades.GestorDeArchivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class LogTest
    {
        [TestMethod]
        public void Escribir_DeberiaCrearYEscribirUnLogEnMisDocumentos()
        {
            Log log = new Log();
            log.Escribir("hola mundo");
            log.Escribir("hola con append");

            bool esperado =File.Exists(Log.ruta);

            Assert.IsTrue(esperado);
        }
        [TestMethod]
        public void Leer_DeberiaLeerMiLogEnMisDocumentos()
        {
            Log log = new Log();
            string leer =log.Leer();

            Console.WriteLine(leer);

            Assert.IsNotNull(leer);
        }
    }
}

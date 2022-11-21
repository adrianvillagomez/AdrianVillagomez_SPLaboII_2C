using Entidades;
using Entidades.GestorSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class LapizDAOTest
    {
        [TestMethod]
        public void Alta_DeberiaDarDeAltaEnMiBaseDeDato()
        {
            Lapiz lapiz = new Lapiz("Faber",300,Color.Azul);
            LapizDAO.Alta(lapiz);
        }
        [TestMethod]
        public void LeerPorId_DeberiaLeerPorIdEnMiBaseDeDatos()
        {
            Lapiz lapiz = LapizDAO.LeerPorID(1);
            Console.WriteLine(lapiz.ToString());
        }
        [TestMethod]
        public void Eliminar_DberiaEliminarPorIdEnMiBaseDeDatos()
        {
            LapizDAO.Eliminar(2);

        }
    }
}

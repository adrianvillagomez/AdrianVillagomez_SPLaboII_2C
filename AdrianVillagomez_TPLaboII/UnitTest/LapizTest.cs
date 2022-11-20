using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UnitTest
{
    [TestClass]
    public class LapizTest
    {
        [TestMethod]
        public void Xml_DeberiaSerializarEnFormatoXMLEnMisDocumentos()
        {
            Lapiz lapiz = new Lapiz("pepito",200,Color.Rojo);
           
            lapiz.SerializarXml($"{lapiz.Marca}");
         
            bool existe = File.Exists($"{Lapiz.ruta}\\pepito.xml");

            Assert.IsTrue(existe);

        }
        [TestMethod]
        public void Xml_DeberiaDeserializarDeMiArchivoXMLEnMisDocumentos()
        {
            Lapiz lapiz2 = new Lapiz("Faber", 500, Color.Verde);

            Lapiz lapiz = lapiz2.Xml("pepito.xml");

            Console.WriteLine($"{lapiz.Marca} {lapiz.Precio} {lapiz.Color}");
            Assert.IsNotNull(lapiz);

        }
        [TestMethod]
        public void Json_DeberiaSerializarEnFormatoJsonEnMisDocumentos()
        {
            Lapiz lapiz = new Lapiz("Faber", 600, Color.Rojo);

            lapiz.SerializarJson("lapizFaaber");

            bool existe = File.Exists($"{Lapiz.ruta}\\lapizFaaber.json");
            Assert.IsTrue(existe);
        }
        [TestMethod]
        public void Json_DeberiaDezerializarDeMisDocumentosUnArchivoJson()
        {
            Lapiz lapiz = new Lapiz("Faber", 600, Color.Rojo);

            Lapiz lapizDeserializado =lapiz.Json("lapizfaaber.json");

            Console.WriteLine($"{lapiz.Marca} {lapiz.Precio} {lapiz.Color}");
            Assert.IsNotNull(lapizDeserializado);
        }
    }
}

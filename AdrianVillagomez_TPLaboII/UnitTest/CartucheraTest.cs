using Entidades;
using Entidades.Excepciones;

namespace UnitTest
{
    [TestClass]
    public class CartucheraTest
    {
        Lapiz?lapiz1;
        SacaPuntas? sacaPuntas;
        Goma?goma;
        List<Utiles>? utiles;
        Cartuchera<Utiles>? cartucheraUtiles;

        [TestInitialize]
        public void Init()
        {
            lapiz1 = new("Faber", 100, Color.Verde);
            sacaPuntas = new("Pepito", 200, "Metal");
            goma = new("Fz", 300);
            utiles = new List<Utiles>
            {
                lapiz1,
                sacaPuntas,
                goma
            };
            cartucheraUtiles = new Cartuchera<Utiles>(4, utiles);
        }
        [TestMethod]
        public void PrecioTotal_DeberiaRetornarLaSumaDeLosPreciosDeTodosMisElementos()
        {          

            decimal totalEsperado = 600;
            decimal Actual = cartucheraUtiles.PrecioTotal;

            Console.WriteLine($"{Actual} ,{totalEsperado}");
            Assert.AreEqual(totalEsperado, Actual);
        }

        [TestMethod]
        public void SobrecargaOperadorMas_DeberiaRetornarTrueSiPudoAgregarConExito()
        {
            Cartuchera<Utiles> cartuchera= new Cartuchera<Utiles>(4, utiles);
            Lapiz lapiz4 = new("Faber", 100, Color.Rojo);

            bool Esperado = cartuchera + lapiz4;

            Assert.IsTrue(Esperado);
        }
        [TestMethod]
        [ExpectedException(typeof(CartucheraLlenaException))]
        public void SobrecargaOperadorMas_DeberiaRetornarFalseSiNoPudoAgregarConExito()
        {
            Cartuchera<Utiles> cartuchera = new Cartuchera<Utiles>(3, utiles);
            Goma goma= new("Faber", 100);

            bool Esperado = cartuchera + goma; 
        }       
    }
}
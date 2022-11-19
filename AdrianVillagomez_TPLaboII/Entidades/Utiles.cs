using System.Text;

namespace Entidades
{
    public abstract class Utiles
    {
        private string marca;
        private decimal precio;

        public Utiles(string marca, decimal precio)
        {
            this.marca = marca;
            this.precio = precio;
        }
        public string Marca { get => marca; set => marca = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Marca: {this.Marca}");
            sb.AppendLine($"Precio: {this.Precio}");

            return sb.ToString();
        }

    }
}
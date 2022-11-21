using System.Text;

namespace Entidades
{
    public abstract class Utiles
    {
        private int id;
        private string marca;
        private int precio;

        public Utiles(string marca, int precio )
        {
            this.marca = marca;
            this.precio = precio;   
        }
        public string Marca { get => marca; set => marca = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id: {this.Id}");
            sb.AppendLine($"Marca: {this.Marca}");
            sb.AppendLine($"Precio: {this.Precio}");

            return sb.ToString();
        }

    }
}
namespace Entidades
{
    public abstract class Utiles
    {
        internal string marca;
        internal decimal precio;

        public Utiles(string marca,decimal precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

    }
}
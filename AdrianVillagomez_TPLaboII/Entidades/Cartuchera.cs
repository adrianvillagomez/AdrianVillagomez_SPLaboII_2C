using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;
namespace Entidades
{
    public delegate void ClaseDelegado();
    public class Cartuchera<T> where T : Utiles
    {
        private int capacidadCartuchera;
        private List<T> listaDeElementos;
        public event ClaseDelegado EventoPrecio;

        public Cartuchera(int capacidadCartuchera, List<T> listaDeElementos)
        {
            this.capacidadCartuchera = capacidadCartuchera;
            this.listaDeElementos = listaDeElementos;
        }

        public decimal PrecioTotal
        {
            get
            {
                decimal precioTotal = 0;
                if (listaDeElementos.Count > 0)
                {
                    listaDeElementos.ForEach(x => precioTotal += x.Precio);
                }
                return precioTotal;
            }
        }

        public List<T> ListaDeElementos { get => listaDeElementos; set => listaDeElementos = value; }
        /// <summary>
        /// Agrega util a mi cartuchera
        /// </summary>
        /// <param name="cartuchera"></param>
        /// <param name="elemento"></param>
        /// <returns></returns>
        /// <exception cref="CartucheraLlenaException"></exception>
        public static bool operator +(Cartuchera<T> cartuchera, T elemento)
        {
            if (cartuchera.capacidadCartuchera > cartuchera.listaDeElementos.Count)
            {
                cartuchera.listaDeElementos.Add(elemento);
                if (cartuchera.PrecioTotal > 500 && cartuchera.EventoPrecio is not null)
                {
                    cartuchera.EventoPrecio.Invoke();
                }
                return true;
            }
            throw new CartucheraLlenaException("Cartuchera llena");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad de la Cartuchera: {this.capacidadCartuchera}");
            sb.AppendLine($"Utiles en la cartuchera: {this.listaDeElementos.Count}");
            foreach (T item in listaDeElementos)
            {
                sb.AppendLine($"Tipo: {item.GetType().Name}");
                if (item is Lapiz)
                {
                    Lapiz lapiz = item as Lapiz;
                    sb.AppendLine($"Color: {lapiz.Color}");
                }
                if (item is SacaPuntas)
                {
                    SacaPuntas sacapuntas = item as SacaPuntas;
                    sb.AppendLine($"Material: {sacapuntas.Material}");
                }
                sb.AppendLine($"{item.ToString()}");
            }
            return sb.ToString();
        }

    }
}

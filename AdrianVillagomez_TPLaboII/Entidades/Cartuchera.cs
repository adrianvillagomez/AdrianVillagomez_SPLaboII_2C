using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera<T> where T : Utiles
    {
        private int capacidadCartuchera;
        private List<T> listaDeElementos;

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
                    listaDeElementos.ForEach(x => precioTotal += x.precio);
                }
                return precioTotal;
            }
        }
        public static bool operator +(Cartuchera<T> cartuchera, T elemento)
        {           
            if (cartuchera.capacidadCartuchera > cartuchera.listaDeElementos.Count)
            {
                cartuchera.listaDeElementos.Add(elemento);
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Color
    {
        Rojo,
        Azul,
        Verde
    }
     
    public class Lapiz : Utiles
    {
        private Color color;
        
        public Lapiz(string marca, decimal precio,Color color) : base(marca, precio)
        {
            this.color = color;
        }

        public Color Color { get => color; set => color = value; }
    }
}

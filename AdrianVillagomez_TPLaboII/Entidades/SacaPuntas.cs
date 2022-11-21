using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SacaPuntas : Utiles
    {
        private string material;
        public SacaPuntas(string marca, int precio, string material) : base(marca, precio)
        {
            this.material = material;
        }

        public string Material { get => material; set => material = value; }

       
    }
}

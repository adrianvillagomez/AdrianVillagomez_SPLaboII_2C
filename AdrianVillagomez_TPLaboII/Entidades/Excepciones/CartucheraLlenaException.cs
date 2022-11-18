using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CartucheraLlenaException : Exception
    {
        public CartucheraLlenaException(string mensaje) : base(mensaje)
        {

        }
        public CartucheraLlenaException(string mensaje,Exception ex ) : base(mensaje,ex)
        {

        }
    }
}

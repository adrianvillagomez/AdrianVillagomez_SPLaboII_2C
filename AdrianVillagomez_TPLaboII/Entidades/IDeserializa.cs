using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     interface IDeserializa
    {
        public Lapiz Xml(string nombreArchivo);
        public Lapiz Json(string nombreArchivo);
    }
}

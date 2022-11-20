using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     interface ISerializa
    {
         public void Xml(string nombreArchivo);
         public void Json(string nombreArchivo);
    }
}

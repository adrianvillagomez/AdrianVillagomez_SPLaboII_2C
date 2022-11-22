using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.GestorDeArchivo
{
    public class Log
    {
        public static string ruta;
        static Log()
        {
            Log.ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ruta += @"\tickets.log";
        }
        /// <summary>
        /// Escribo en un log y si no exite lo crea.
        /// </summary>
        /// <param name="contenido"></param>
        /// <exception cref="Exception"></exception>
         public void Escribir(string contenido)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    streamWriter.WriteLine(contenido);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al escribir el archivo", ex);
            }
        }
        /// <summary>
        /// Leo mi Log ubicado en mis documentos.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string Leer()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer", ex);
            }

        }
    }
}

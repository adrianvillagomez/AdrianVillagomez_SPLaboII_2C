using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.GestorDeArchivo
{
    public static class LogBackUp
    {
        public static string ruta;
        static LogBackUp()
        {
            LogBackUp.ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ruta += @"\BuckUp.log";
        }
        public static void Escribir(string contenido)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta,true))
                {
                    streamWriter.WriteLine(contenido);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al escribir el archivo", ex);
            }
        }
        public static string Leer()
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

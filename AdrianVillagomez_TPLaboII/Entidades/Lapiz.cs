using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using Entidades.GestorDeArchivo;
using System.IO;
using System.Globalization;
using System.Text.Json;

namespace Entidades
{
    public enum Color
    {
        Rojo,
        Azul,
        Verde
    }

    public class Lapiz : Utiles, IDeserializa, ISerializa
    {
        private Color color;
        public static string ruta;
        static Lapiz()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public Lapiz(string marca, int precio, Color color) : base( marca, precio)
        {
            this.color = color;
        }
        public Lapiz() : this("", 0, Color.Azul)
        {

        }
        public Color Color { get => color; set => color = value; }

        public Lapiz Json(string ruta)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    string json = streamReader.ReadToEnd();
                    return JsonSerializer.Deserialize<Lapiz>(json);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Deserializar Json",ex);
            }
        }
        /// <summary>
        /// Metodo Para Deserealizar XML.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Lapiz Xml(string ruta)
        {
            try
            {
                using (XmlTextReader xmlTextReader = new XmlTextReader(ruta))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Lapiz));
                    return serializer.Deserialize(xmlTextReader) as Lapiz;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Al Deserializar XML", ex);
            }
        }

        void ISerializa.Json(string nombreArchivo)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter($"{ruta}\\{nombreArchivo}"))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    string ser = JsonSerializer.Serialize(this,typeof(Lapiz),options);
                    streamWriter.WriteLine(ser);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar Json",ex);
            }
        }

        void ISerializa.Xml(string nombreArchivo)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter($"{ruta}\\{nombreArchivo}"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Lapiz));
                    serializer.Serialize(streamWriter, this);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Al Serializar Json", ex);
            }

        }
        public void SerializarXml(string nombreArchivo)
        {
            ((ISerializa)this).Xml($"{nombreArchivo}.xml");
        }
        public void SerializarJson(string nombreArchivo)
        {
            ((ISerializa)this).Json($"{nombreArchivo}.json");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Color : {this.color}");
            return sb.ToString();
        }
    }
}

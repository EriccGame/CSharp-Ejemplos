using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SimpleXML
{
    class Program
    {
        static String sFileName;

        static void Main(string[] args)
        {
            sFileName = "SimpleXML.xml";
            CrearXML();
            LeerXML();
            Console.ReadKey();
        }

        static void CrearXML()
        {
            XmlTextWriter xmlWriter = new XmlTextWriter(sFileName, Encoding.UTF8);

            xmlWriter.Formatting = Formatting.Indented;

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("Ejemplo");

            xmlWriter.WriteElementString("Nodo1", "Texto1");
            xmlWriter.WriteElementString("Nodo2", "Texto2");

            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();
        }

        static Hashtable LeerXML()
        {
            Hashtable table = new Hashtable();
            XmlTextReader xmlReader = new XmlTextReader(sFileName);
            String sAtributo = String.Empty, sNombre = String.Empty;

            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    sNombre = xmlReader.Name;
                }
                else
                {
                    if (xmlReader.NodeType == XmlNodeType.Text)
                    {
                        sAtributo = xmlReader.Value.Replace("\r\n", String.Empty).Trim();
                    }
                }

                if (sAtributo != String.Empty && sNombre != String.Empty)
                {
                    table.Add(sNombre, sAtributo);
                    Console.WriteLine(String.Format("Nombre: {0}, Atributo: {1}", sNombre, sAtributo));
                    sNombre = String.Empty;
                    sAtributo = String.Empty;
                }
            }
            xmlReader.Close();
            return table;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace SimpleJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto P = new Producto();
            P.Nombre = "Tenis";
            P.Cantidad = 10;
            P.Precio = 15.5;
            P.Tamaño = new String[] { "EC", "CH", "M", "G", "EG" };

            String sJson = JsonConvert.SerializeObject(P, Formatting.Indented);

            FileStream FS = new FileStream(@"C:\Example\JsonFile.json", FileMode.OpenOrCreate);
            StreamWriter SW = new StreamWriter(FS, Encoding.UTF8);
            SW.Write(sJson);
            SW.Flush();
            SW.Close();

            Console.Write(sJson);
            Console.ReadKey();
        }
    }
}

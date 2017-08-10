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

            String sPath = Path();

            if (sPath.Trim().Length > 0)
            {
                FileStream FS = new FileStream(Path() + "ArchivoJSON.json", FileMode.OpenOrCreate);
                StreamWriter SW = new StreamWriter(FS, Encoding.UTF8);
                SW.Write(sJson);
                SW.Flush();
                SW.Close();

                Console.Write(sJson);
            }
            else
            {
                Console.Write("No se pudo crear el archivo JSON");
            }
            Console.ReadKey();
        }

        static String Path()
        {
            String sPath = @"C:\Ejemplo\";

            try
            {
                if (!Directory.Exists(sPath))
                {
                    DirectoryInfo DI = Directory.CreateDirectory(sPath);
                    Console.WriteLine("Se ha creado la direccion con la fecha: {0}.", Directory.GetCreationTime(sPath));
                    return sPath;
                }
                else
                {
                    return sPath;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el proceso: {0}", e.ToString());
                return "";
            } 
        }
    }
}

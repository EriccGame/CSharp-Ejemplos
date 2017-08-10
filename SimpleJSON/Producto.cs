using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleJSON
{
    class Producto
    {
        private String sNombre;
        private Int32 iCantidad;
        private Double dPrecio;
        private String[] sTamaño;

        public String Nombre
        {
            get { return sNombre; }
            set { sNombre = value; }
        }

        public Int32 Cantidad
        {
            get { return iCantidad; }
            set { iCantidad = value; }
        }

        public Double Precio
        {
            get { return dPrecio; }
            set { dPrecio = value; }
        }

        public String[] Tamaño
        {
            get { return sTamaño; }
            set { sTamaño = value; }
        }
    }
}

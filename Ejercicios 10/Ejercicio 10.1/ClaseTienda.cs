using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_10._1
{
    public class ClaseTienda
    {
        public float Precio { get; set; }
        public int Unidades { get; set; }
        public String NombreProducto { get; set; }

        public ClaseTienda()
        {
            Precio = 0;
            Unidades = 0;
            NombreProducto = string.Empty;
        }

        public ClaseTienda(float pPrecio,int uUnidades,String nNombreProducto)
        {
            Precio = pPrecio;
            Unidades = uUnidades;
            NombreProducto = nNombreProducto;
        }

        public override string ToString()
        {
            String Mensaje = "";
            Mensaje += "Precio: "+Precio.ToString()+"Unidades: "+Unidades.ToString()+
                "Nombre del producto: "+NombreProducto.ToString();
            return Mensaje;
        }
    }
}

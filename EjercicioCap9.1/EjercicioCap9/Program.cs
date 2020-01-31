using System;
using System.Text;

namespace EjercicioCap9._1
{
    class Program
    {
        public struct Producto
        {
            public float Precio;
            public String Nombre;
            public int Cantidad;

            public Producto(float pPrecio, String nNombre, int cCantidad)
            {
                Precio = pPrecio;
                Nombre = nNombre;
                Cantidad = cCantidad;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre Producto: {0}, Cantidad del Producto: {1}, Precio del Producto: {2}", Nombre, Cantidad, Precio);
                return sb.ToString();
            }
        }

        static void Main(string[] args)
        {
            Producto Tienda;
            float fPrecio;
            int ICantidad;
            String SNombre;

            Console.WriteLine("Ingrese el nombre del producto");
            SNombre = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto");
            fPrecio = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad del producto");
            ICantidad = Convert.ToInt32(Console.ReadLine());

            Tienda = new Producto(fPrecio, SNombre, ICantidad);

            Console.WriteLine(Tienda.ToString());
        }
    }
}
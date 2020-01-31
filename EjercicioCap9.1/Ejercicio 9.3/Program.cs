using System;
using System.Text;

namespace Ejercicio_9._3
{
    class Program
    {
        public struct Dueno 
        {
            public String Nombre;
            public String Direccion;
            public String Telefono;

            public Dueno(String nNombre,String dDireccion,String tTelefono) 
            {
                Nombre = nNombre;
                Direccion = dDireccion;
                Telefono = tTelefono;
            }

            public override string ToString()
            {
                StringBuilder sd = new StringBuilder();
                sd.AppendFormat("Nombre del Dueño: {0}, Telefono del Dueño: {2}, Dirección del Dueño: {1}", Nombre, Direccion, Telefono);
                return sd.ToString();
            }
        }

        public struct Mascota 
        {
            public String Nombre;
            public String Raza;
            public Dueno Jefe;

            public Mascota(String NombreMascota,String rRaza,String NombreDueno,String DireccionD,String TelefonoD)
            {
                Nombre = NombreMascota;
                Raza = rRaza;
                Jefe = new Dueno(NombreDueno, DireccionD, TelefonoD);
            }

            public override string ToString()
            {
                StringBuilder sd = new StringBuilder();
                sd.AppendFormat("Nombre de la Mascota: {0}, Raza de la Mascota: {1}", Nombre, Raza);
                sd.Append(Jefe.ToString());
                return sd.ToString();
            }
        }
        static void Main(string[] args)
        {
            Mascota mascota;
            String NombreM, NombreD, Raza, Direccion, Telefono;

            Console.WriteLine("Nombre de la mascota");
            NombreM = Console.ReadLine();
            Console.WriteLine("Raza de la mascota");
            Raza = Console.ReadLine();
            Console.WriteLine("Nombre del dueño");
            NombreD = Console.ReadLine();
            Console.WriteLine("Direccion");
            Direccion = Console.ReadLine();
            Console.WriteLine("Telefono");
            Telefono = Console.ReadLine();

            mascota = new Mascota(NombreM, Raza, NombreD, Direccion, Telefono);

            Console.WriteLine(mascota.ToString());
        }
    }
}

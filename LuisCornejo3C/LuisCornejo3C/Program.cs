using System;

namespace LuisCornejo3C
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Teacher :)!");

            ETemporal ETemporal = new ETemporal("Cornejo", "Luis", 19, "Bodeguero","19/06/2015", "19/12/2020");
            Console.WriteLine("**Empleado que trabaja temporalmente**");
            ETemporal.ImprimirDatos();
            Console.WriteLine("");
            Console.WriteLine("");

            Empleado Empleado = new Empleado("Rodriguez", "Andres", 17, "Recepcionista");
            Console.WriteLine("Datos de un empleado");
            Empleado.ImprimirDatos();
            Console.WriteLine("");
            Console.WriteLine("");


            EPorHora EPorHora = new EPorHora("Cadena", "Felix", 30, "Gerente xD", 20, 20);
            Console.WriteLine("**Empleado que trabaja por hora**");
            EPorHora.ImprimirDatos();
            Console.WriteLine("");
            Console.WriteLine("");


            EFijo EFijo = new EFijo("Macias", "Yaleska", 20, "Recepcionista", 2010);
            Console.WriteLine("**Empleado que tiene un trabajo Fijo**");
            EFijo.ImprimirDatos();
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}

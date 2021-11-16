using System;

namespace TADColaDeber
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola objetocola = new Cola();
            Console.WriteLine("Estableciendo 5 elementos...");

            objetocola.Encolar(4);
            objetocola.Encolar(10);
            objetocola.Encolar(2);
            objetocola.Encolar(54);
            objetocola.Encolar(12);
            objetocola.Mostrar();

            Console.WriteLine("Eliminando dos elementos...");
            objetocola.Desencolar();
            objetocola.Mostrar();
            objetocola.Desencolar();
            objetocola.Mostrar();

            Console.WriteLine("Se va a eliminar un nodo más con el valor de (0)", objetocola.DesencolarValor());
            objetocola.Mostrar();
            Console.ReadLine();

        }
    }
}

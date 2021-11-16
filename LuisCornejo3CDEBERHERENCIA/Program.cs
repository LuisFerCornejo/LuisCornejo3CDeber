using System;

namespace LuisCornejo3CDEBERHERENCIA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Información con las personas vinculadas con la facultad!");
            Console.WriteLine("");
            Estudiante Estudiante = new Estudiante("Cornejo", "Luis", 1313839555, "Soltero", "3C");
            Console.WriteLine("**Datos del Estudiante**");
            Estudiante.ImprimirDatosEstudiante();
            Console.WriteLine("");
            Console.WriteLine("");

            Empleado EmpleadoP = new Empleado("Mero", "Alfredo", 1306589874, "Casado", "Profesor");
            Console.WriteLine("**Datos del empleado**");
            EmpleadoP.ImprimirDatosEmpleado();
            Console.WriteLine("");
            Console.WriteLine("");


            Empleado EmpleadoS = new Empleado("Cedeño", "Mayerly", 1315252487, "Casada", "Personal de servicio");
            Console.WriteLine("**Datos del empleado**");
            EmpleadoS.ImprimirDatosEmpleado();
            Console.WriteLine("");
            Console.WriteLine("");


            Profesor Profesor = new Profesor("Mero", "Alfredo", 1306589874, "Casado", "Profesor", 2015, 20, "Arquitectura");
            Console.WriteLine("**Datos del profes@r**");
            Profesor.ImprimirDatosEmpleado();
            Console.WriteLine("");
            Console.WriteLine("");


            PersonalServicio PersonalServicio = new PersonalServicio("Cedeño", "Mayerly", 1315252487, "Casada", "Personal de servicio", 2010, 11, "Biblioteca");
            Console.WriteLine("**Datos del personal de servicio**");
            PersonalServicio.ImprimirDatosEmpleado();
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}

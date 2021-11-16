using System;
using System.Collections.Generic;
using System.Text;

namespace LuisCornejo3CDEBERHERENCIA
{

    
    public class Profesor:Empleado
    {

        int AñoIngreso;
        int NumeroDespacho;
        string Departamento;
        
        public Profesor (string Apellido, string Nombre, int Cedula, string EstadoCivil, string Puesto, int AñoIngreso, int NumeroDespacho, string Departamento) : base(Apellido, Nombre, Cedula, EstadoCivil, Puesto)
        {
            this.AñoIngreso = AñoIngreso;
            this.NumeroDespacho = NumeroDespacho;
            this.Departamento = Departamento;
        }

        public override void ImprimirDatosEmpleado()
        {
            base.ImprimirDatosEmpleado();
            Console.WriteLine("El año en el que el docente ingreso a trabajar es: " +AñoIngreso);
            Console.WriteLine("El número de despacho con el que el docente cuenta es: " +NumeroDespacho);
            Console.WriteLine("El depatamento con el que el docente cuenta es: " +Departamento);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LuisCornejo3C
{
    public class ETemporal: Empleado
    {
         string FechaIngreso;
         string FechaSalida;

        public ETemporal (string Apellido, string Nombre, int Edad, string Departamento, string FechaIngreso, string FechaSalida):base(Apellido, Nombre, Edad, Departamento)
        {
            this.FechaIngreso =  FechaIngreso;
            this.FechaSalida =  FechaSalida;
        }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos();
            Console.WriteLine("La fecha de ingreso del empleado es: " + FechaIngreso + " Y la fecha de salida del empleado es: " + FechaSalida+ " siendo su sueldo: 800 dolares");

        }
    }
}

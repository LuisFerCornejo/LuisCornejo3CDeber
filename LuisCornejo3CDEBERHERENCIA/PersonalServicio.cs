using System;
using System.Collections.Generic;
using System.Text;

namespace LuisCornejo3CDEBERHERENCIA
{
    public class PersonalServicio: Empleado
    {
        int AñoIngresoS;
        int NumeroDespachoS;
        string Seccion;

        public PersonalServicio (string Apellido, string Nombre, int Cedula, string EstadoCivil, string Puesto, int AñoIngresoS, int NumeroDespachoS, string Seccion) : base(Apellido, Nombre, Cedula, EstadoCivil, Puesto)
        {
            this.AñoIngresoS = AñoIngresoS;
            this.NumeroDespachoS = NumeroDespachoS;
            this.Seccion = Seccion;
        }
        public override void ImprimirDatosEmpleado()
        {
            base.ImprimirDatosEmpleado();
            Console.WriteLine("El año en el que el empleado de servicio entro a trabajar es de: " +AñoIngresoS);
            Console.WriteLine("El numero de despacho con el que cuenta el empleado de servicio es de: " +NumeroDespachoS);
            Console.WriteLine("La seccion en la que trabaja el empleado de servicio es: " +Seccion);

        }

    }
}

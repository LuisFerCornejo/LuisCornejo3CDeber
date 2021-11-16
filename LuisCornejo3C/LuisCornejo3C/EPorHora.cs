using System;
using System.Collections.Generic;
using System.Text;

namespace LuisCornejo3C
{
    public class EPorHora:Empleado
    {
        public int PrecioH;
        public int HTrabajada;
        int Paga;
        public EPorHora(string Apellido, string Nombre, int Edad, string Departamento, int PrecioH, int HTrabajada):base(Apellido, Nombre, Edad, Departamento)
        {
            this.PrecioH = PrecioH;
            this.HTrabajada = HTrabajada;
            Paga = 20 * HTrabajada;
        }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos();
            Console.WriteLine("El precio que al empleado le pagan por hora es de: " + PrecioH + " siendo así que las horas que trabajadas son: " + HTrabajada + " Y por lo tanto su pago será " +Paga+ " dolares");
        }
    }
}

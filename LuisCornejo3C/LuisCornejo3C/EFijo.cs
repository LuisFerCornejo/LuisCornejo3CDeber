using System;
using System.Collections.Generic;
using System.Text;

namespace LuisCornejo3C
{
     public class EFijo: Empleado
    {
        public int AñoEntrada;
        int Paga;
        public EFijo(string Apellido, string Nombre, int Edad, string Departamento, int AñoEntrada):base(Apellido, Nombre, Edad, Departamento)
        {
            this.AñoEntrada = AñoEntrada;
            Paga = 50 * (2021 - AñoEntrada) + 400;
            //50 es mi complmento anual
        }

        public override void ImprimirDatos()
        {
            base.ImprimirDatos();
            Console.WriteLine("El año en el que entro a laborarl el empleado es: " + AñoEntrada+ " y su paga es de: " +Paga);
        }
    }
}

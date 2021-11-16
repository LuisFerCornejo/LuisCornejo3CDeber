using System;
using System.Collections.Generic;
using System.Text;

namespace LuisCornejo3C
{
    public class Empleado
    {
        private string Apellido;
        private string Nombre;
        private int Edad;
        private string Departamento;

        public Empleado(string Apellido, string Nombre, int Edad, string Departamento)
        {
            this.Apellido = Apellido;
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Departamento = Departamento;
        }

        public string getApellido()
        {
            return Apellido;
        }
        public void setApellido(string Apellido)
        {
            this.Apellido = Apellido;
        }


        public string getNombre()
        {
            return Nombre;
        }
        public void setNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }


        public int getEdad()
        {
            return Edad;
        }
        public void setEdad(int Edad)
        {
            this.Edad = Edad;
        }



        public string getDepartamento()
        {
            return Departamento;
        }
        public void setDepartamento(string Departamento)
        {
            this.Departamento = Departamento;
        }


        public virtual void ImprimirDatos()
        {
            Console.WriteLine("Datos del empleado -> Nombre: " + Nombre + "  Apellido: " + Apellido + "  Edad: " + Edad + "  Departamento: " + Departamento);
        }
    }
}

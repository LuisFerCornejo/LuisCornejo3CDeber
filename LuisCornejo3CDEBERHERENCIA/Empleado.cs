using System;
using System.Collections.Generic;
using System.Text;

namespace LuisCornejo3CDEBERHERENCIA
{
    public class Empleado
    {
        private string Apellido;
        private string Nombre;
        private int Cedula;
        private string EstadoCivil;
        private string Puesto;

        public Empleado(string Apellido, string Nombre, int Cedula, string EstadoCivil, string Puesto)
        {
            this.Apellido = Apellido;
            this.Nombre = Nombre;
            this.Cedula = Cedula;
            this.EstadoCivil = EstadoCivil;
            this.Puesto = Puesto;
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


        public int getCedula()
        {
            return Cedula;
        }
        public void setCedula(int Cedula)
        {
            this.Cedula = Cedula;
        }



        public string getEstadoCivil()
        {
            return EstadoCivil;
        }
        public void setDepartamento(string EstadoCivil)
        {
            this.EstadoCivil = EstadoCivil;
        }


        public string getPuesto()
        {
            return Puesto;
        }
        public void setPuesto(string Puesto)
        {
            this.Puesto = Puesto;
        }


        public virtual void ImprimirDatosEmpleado()
        {
            Console.WriteLine("Nombre: "+Nombre);
            Console.WriteLine("Apellido: "+Apellido);
            Console.WriteLine("Cédula: "+Cedula);
            Console.WriteLine("Estado Civil: "+EstadoCivil);
            Console.WriteLine("Puesto: "+Puesto);
        }
    }
}

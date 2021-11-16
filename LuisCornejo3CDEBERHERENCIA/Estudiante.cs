using System;
using System.Collections.Generic;
using System.Text;

namespace LuisCornejo3CDEBERHERENCIA
{
    public class Estudiante
    {
        private string Apellido;
        private string Nombre;
        private int Cedula;
        private string EstadoCivil;
        private string Curso;

        public Estudiante(string Apellido, string Nombre, int Cedula, string EstadoCivil, string Curso)
        {
            this.Apellido = Apellido;
            this.Nombre = Nombre;
            this.Cedula = Cedula;
            this.EstadoCivil = EstadoCivil;
            this.Curso = Curso;
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


        public string getCurso()
        {
            return Curso;
        }
        public void setCurso(string Curso)
        {
            this.Curso = Curso;
        }


        public virtual void ImprimirDatosEstudiante()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Cédula: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            Console.WriteLine("Curso: " + Curso);
        }
    }
}

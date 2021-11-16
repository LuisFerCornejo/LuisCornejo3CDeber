using System;
using System.Collections.Generic;
using System.Text;

namespace TADColaDeber
{
    class Cola
    {
        public Nodo Primero;
        public Nodo Ultimo;

        public Cola()
        {
            Primero = Ultimo = null;
        }

        public void Encolar (int Valor)
        {
            Nodo Aux = new Nodo();
            Aux.info = Valor;
            if(Primero == null)
            {
                Primero = Ultimo = Aux;
                Aux.sgte = null;
            }
            else
            {
                Ultimo.sgte = Aux;
                Aux.sgte = null;
                Ultimo = Aux;
            }
        
        }
        public void Desencolar()
        {
            if (Primero == null) Console.WriteLine("Cola Vacía");
            else Primero = Primero.sgte;

        }

        public int DesencolarValor()
        {
            int Valor = 0;
            if (Primero == null) Console.WriteLine("Cola Vacia");
            else
            {
                Valor = Primero.info;
                Primero = Primero.sgte;
            }
            return Valor;

        }

        public void Mostrar()
        {
            if (Primero == null) Console.WriteLine("Cola Vacía");
            else
            {
                Nodo Puntero;
                Puntero = Primero;

                do
                {
                    Console.WriteLine("{0} / t", Puntero.info);
                    Puntero = Puntero.sgte;
                }
                while (Puntero != null);
            }
            Console.WriteLine("/n");
        }
    }
}

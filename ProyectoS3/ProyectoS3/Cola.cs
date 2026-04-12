using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoS3
{
    public class Cola
    {
        Nodo cabeza,ant;

        public Cola()
        {
            cabeza = null;
        }

        // Método Encolar (Push, Insertar)
        public void Encolar(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (EstaVacia())
            {
                cabeza = ant = nuevo;
            } else
            {
                ant.sig = nuevo;
                ant = nuevo;
            }
        }
        // Método Desencolar (Pop,Suprimir)
        // Vamos a eliminar el Nodo que tiene cabeza
        public int Desencolar()
        {
            int aux;
            if (!EstaVacia())
            {
                aux = cabeza.info;
                cabeza = cabeza.sig;
            }
            else aux = 0;
            return aux;
        }

        // Método Ver (Peek,Espiar)
        public void Ver()
        {
            Nodo ptr = cabeza;
            while (ptr != null)
            {
                Console.Write("{0},", ptr.info);
                ptr = ptr.sig;
            }

        }

        // Método EstaVacia
        public bool EstaVacia()
        {
            return cabeza == null;
        }

    }
}

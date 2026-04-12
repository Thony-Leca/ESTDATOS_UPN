using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoS3
{

    // Las pilas son estructuras de datos que siguen el principio LIFO
    public class Pila
    {
        Nodo tope;

        // Método constructor
        public Pila()
        {
            tope = null;
        }

        // Método Apilar (Push)
        public void Apilar(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            //if (tope == null)
            //{
            //    //nuevo.sig = null;
            //    tope = nuevo;
            //}
            //else
            //{
            //    tope.sig = nuevo;
            //    tope = nuevo;
            //    //nuevo.sig = null;  --En el constructor ya asignamos null a los .sig
            //}
            nuevo.sig = tope;
            tope = nuevo;

        }

        // Método Desapilar (Pop)
        // Eliminar el último elemento apilado (osea el que tiene el tope)
        public int Desapilar()
        {
            if(!PilaVacia())
            {
                int aux = tope.info;
                tope = tope.sig;
                return aux;
            } else
            {
                return 0;
            }
        }

        // Método Tomar (Peek)
        public void Tomar()
        {
            Nodo ptr = tope;
            while ( ptr != null)
            {
                Console.Write( "{0},", ptr.info );
                ptr = ptr.sig;
            }
        }

        // Método PilaVacia (IsEmpty)
        public bool PilaVacia()
        {
            return(tope == null );
        }

    }
}

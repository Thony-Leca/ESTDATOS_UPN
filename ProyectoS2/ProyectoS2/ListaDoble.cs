using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoS2
{
    public class ListaDoble
    {
        Nodo raiz1, raiz2, ptr, nuevo;
        // Costructor
        public ListaDoble() {
            raiz1 = raiz2 = null;
        }

        // INSERTARLIFO
        public void InsertarLIFO(int dato) {
            nuevo = new Nodo();
            nuevo.info = dato;
            if (raiz1 == null)
            {
                nuevo.sig = nuevo.ant = null;
                raiz1 = raiz2 = nuevo;
            }
            else
            {
                nuevo.sig = raiz1;
                nuevo.ant = null;
                raiz1.ant = nuevo;
                raiz1 = nuevo;
            }
        }

        // INSERTARFIFO
        public void InsertarFIFO(int dato)
        {

            nuevo = new Nodo();
            nuevo.info = dato;
            if (raiz2 == null)
            {
                nuevo.sig = nuevo.ant = null;
                raiz1 = raiz2 = nuevo;
            }
            else
            {
                nuevo.sig = null;
                nuevo.ant = raiz2;
                raiz2.sig = nuevo;
                raiz2 = nuevo;
            }
        }

        // RECORRIDO
        public void Recorrido()
        {
            ptr = raiz1;
            Console.WriteLine("\n ---- LISTADO DE ELEMENTOS ----");
            while( ptr != null )
            {
                Console.Write("{0},", ptr.info);
                ptr = ptr.sig;
            }
            Console.WriteLine("");
        }

        // BUSCAR 
        public bool Buscar(int dato)
        {
            bool encontrado = false;
            ptr = raiz1;
            while ( ptr != null && !encontrado )
            {
                if( ptr.info == dato)
                {
                    encontrado = true;
                }else
                {
                    ptr = ptr.sig;
                }
            }
            return encontrado;
        }

        // ELIMINAR
        public bool Eliminar(int dato)
        {
            ptr = raiz1;
            bool encontrado = false;
            if (raiz1.info == dato)
            {
                raiz1 = raiz1.sig;
                raiz1.ant = null;
                encontrado = true;
            } else if (raiz2.info == dato)
            {
                raiz2 = raiz2.ant;
                raiz2.sig = null;
                encontrado = true;
            } else
            {
                // Búsqueda
                while (ptr != null && !encontrado) { 
                    if (ptr.info == dato)
                    {
                        encontrado = true;
                    } else { ptr = ptr.sig; }
                }
                if (encontrado)
                {
                    ptr.ant.sig = ptr.sig;
                    ptr.sig.ant = ptr.ant;
                }
            }
            return encontrado;
        }

        // ORDENAR
        public void Ordenar()
        {
            Nodo ptr1, ptr2;
            ptr1 = raiz1;
            while (ptr1 != null)
            {
                ptr2 = raiz1;
                while (ptr2 != null)
                {
                    if (ptr1.info > ptr2.info)
                    {
                        int aux = ptr1.info;
                        ptr1.info = ptr2.info;
                        ptr2.info = aux;
                    }
                    ptr2 = ptr2.sig;
                }
                ptr1 = ptr1.sig;
            }
        }
    }
}

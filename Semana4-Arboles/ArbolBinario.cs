using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_Arboles
{
    public class ArbolBinario
    {
        Nodo raiz;
        public ArbolBinario()
        {
            raiz = null;
        }

        public void Insertar(int dato)
        {
            raiz = InsertarRecursivo(raiz, dato);
        }

        private Nodo InsertarRecursivo(Nodo nodo, int dato)
        {
            //Si el nodo està vacìo se instancia
            if (nodo == null) return new Nodo(dato);
            // Se compara el nuevo dato con lo que existe en info
            if (dato < nodo.info)
                nodo.izq = InsertarRecursivo(nodo.izq, dato);
            if (dato > nodo.info)
                nodo.der = InsertarRecursivo(nodo.der, dato);
            return nodo;
        }
        public void PreOrden()
        {
            RecorrerPreOrden(raiz);
        }
        private void RecorrerPreOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                Console.Write("{0}, ", nodo.info); // Raíz
                RecorrerPreOrden(nodo.izq); // Subárbol izquierdo
                RecorrerPreOrden(nodo.der); // Subárbol derecho
            }
        }
        public void InOrden()
        {
            RecorrerInOrden(raiz);
        }
        private void RecorrerInOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                RecorrerInOrden(nodo.izq); // Subárbol izquierdo
                Console.Write("{0}, ", nodo.info); // Raíz
                RecorrerInOrden(nodo.der); // Subárbol derecho
            }
        }
        public void PostOrden()
        {
            RecorrerPostOrden(raiz);
        }

        private void RecorrerPostOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                RecorrerPostOrden(nodo.izq); // Subárbol izquierdo
                RecorrerPostOrden(nodo.der); // Subárbol derecho
                Console.Write("{0}, ", nodo.info); // Raíz
            }
        }

        public bool Existe(int dato)
        {
            return BuscarRecursivo(raiz, dato);
        }
        private bool BuscarRecursivo(Nodo nodo, int dato)
        {
            if (nodo == null) return false;
            if (dato == nodo.info) return true;
            return dato < nodo.info
                ? BuscarRecursivo(nodo.izq, dato)
                : BuscarRecursivo(nodo.der, dato);
        }
        public bool Buscar(int dato)
        {
            return BuscarRecursivo(raiz, dato);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_Arboles
{
    public class Nodo
    {
        public int info { get; set; }
        public Nodo izq { get; set; }
        public Nodo der { get; set; }

        public Nodo(int dato)
        {
            info = dato;
            izq = null;
            der = null;
        }
    }
}

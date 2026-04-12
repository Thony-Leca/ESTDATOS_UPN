using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoS3
{
    public class Nodo
    {
        public int info {  get; set; }
        public Nodo sig { get; set; }

        public Nodo(int info)
        {
            this.info = info;
            this.sig = null;
        }
    }
}

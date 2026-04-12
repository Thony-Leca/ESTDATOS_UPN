using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoS3
{
    public class UsoCola
    {
        public static void Main()
        {
            Random rnd = new Random();
            Cola miCola = new Cola();
            int n;
            for (int i = 0; i < 10; i++) miCola.Encolar(rnd.Next(10, 100));

            Console.WriteLine("\n ----------Método ver------------");
            miCola.Ver();
            Console.WriteLine("\n ----------Desencolando------------");
            do
            {
                n = miCola.Desencolar();
                if (n != 0) Console.Write("{0},", n);
            } while (n != 0);
        }
    }
}

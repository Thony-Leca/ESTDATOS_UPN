using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoS3
{
    public class UsoQueue
    {
        public static void Main()
        {
            Queue<int> miCola = new Queue<int>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++) miCola.Enqueue(rnd.Next(10,99));
            Console.WriteLine("\n---Desencolando Elementos de la cola---");
            for (int i = 0;i < 10;i++) Console.Write("{0},", miCola.Dequeue());
        }
    }
}

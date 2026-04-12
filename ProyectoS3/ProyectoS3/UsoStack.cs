using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoS3
{
    public class UsoStack
    {
        public static void Main()
        {
            Random rnd = new Random();
            Stack<int> miPila = new Stack<int>();

            for (int i = 0; i < 10; i++) miPila.Push(rnd.Next(10,99));
            Console.WriteLine("\n---Elementos de la pila---");
            for (int i = 0;i < 10;i++) Console.Write("{0},", miPila.Pop());
        }
    }
}

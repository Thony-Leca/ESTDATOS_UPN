using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoS3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila mipila = new Pila();
            Random rnd = new Random();
            for(int i =1; i<=10; i++)
            {
                mipila.Apilar(rnd.Next(10, 100));
            }
            Console.WriteLine("-------------Recorriendo con método Peek-------------");
            mipila.Tomar();

            Console.WriteLine("\n-------------Desapilando -------------");
            int n;
            do
            {
                n = mipila.Desapilar();
                if (n != 0)
                {
                    Console.WriteLine("{0}", n);
                }
            }while (n != 0);
            Console.WriteLine("-------------Pila Vacía -------------");
            Console.ReadLine();
        }
    }
}

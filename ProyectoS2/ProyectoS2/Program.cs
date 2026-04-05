using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoS2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListaDoble milista = new ListaDoble();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                milista.InsertarFIFO(rnd.Next(10, 100));
            }

            // Imprimir
            milista.Recorrido();

            //int dato = 0;
            //bool res = false;
            //string msg = "";
            // Buscar
            //Console.WriteLine("Método Buscar:  Para finalizar escribe -1");
            //while(dato != -1)
            //{
            //    dato = Int32.Parse(Console.ReadLine());
            //    res = milista.Buscar(dato);
            //    //if (res)
            //    //{
            //    //    Console.WriteLine("Dato {0} Encontrado.", dato);
            //    //} else
            //    //{
            //    //    Console.WriteLine("Dato {0} No se encontró. Intenta nuevamente", dato);
            //    //}
            //    msg = res ? "Se encontró." : "No se encontró. Intenta nuevamente.";

            //    Console.WriteLine("Dato {0} " + msg, dato);
            //}

            // Eliminar
            //Console.WriteLine("Método Eliminar:  Para finalizar escribe -1");
            //do
            //{
            //    dato = Int32.Parse(Console.ReadLine());
            //    res = milista.Eliminar(dato);

            //    msg = res ? "Se eliminó." : "No se eliminó.";
            //    Console.WriteLine("Dato {0} " + msg, dato);
            //    milista.Recorrido();

            //} while (dato != -1);


            // Ordenar
            milista.Ordenar();
            Console.Write("DATOS ORDENADOS");
            milista.Recorrido();


        }
    }
}

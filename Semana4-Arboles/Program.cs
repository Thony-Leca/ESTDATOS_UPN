using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_Arboles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            ArbolBinario arbol = new ArbolBinario();

            for (int i = 0; i < 10; i++)
            {
                arbol.Insertar(rnd.Next(10, 99));
            }
            //Recorrido del arbol
            Console.Write("\nRecorrido PreOrden: ");
            arbol.PreOrden();
            Console.Write("\nRecorrido InOrden: ");
            arbol.InOrden();
            Console.Write("\nRecorrido PostOrden: ");
            arbol.PostOrden();

            //Buscar un valor en el arbol
            do
            {
                Console.Write("\nIngrese un valor a buscar: ");
                int valor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El valor {0}", arbol.Buscar(valor)? "existe":"no existe");
                Console.Write("¿Desea continuar? (S/N): ");
            }while(Console.ReadLine().ToUpper() == "S");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaS1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListaSimple lista = new ListaSimple();
            // Añadir 5 elementos
            lista.InsertarFIFO("Cesar");
            lista.InsertarFIFO("Anthony");
            lista.InsertarFIFO("José");
            lista.InsertarFIFO("Joshimar");
            lista.InsertarFIFO("Renato");
            // Listar los elementos
            Console.WriteLine("--- LISTADO DE ELEMENTOS ---");
            lista.Recorrido();
            // Ordenar los elementos
            lista.Ordenar();
            // Listar los elementos
            Console.WriteLine("--- LISTADO DE ELEMENTOS ---");
            lista.Recorrido();
            // Buscar elemento
            string dato;
            do
            {
                Console.Write("\nDATO A BUSCAR ('fin' FIN):");
                dato = Console.ReadLine();
                Console.WriteLine("{0} {1} ENCONTRADO", dato,
                    lista.Buscar(dato) == 1 ? "SI" : "NO");
            } while (dato != "fin");
            // Eliminar elemento
            do
            {
                Console.Write("\nDATO A ELIMINAR ('fin' FIN):");
                dato = Console.ReadLine();
                lista.Eliminar(dato);
            } while (dato != "fin");

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoS3
{
    public class OperadoresPrioridad
    {

        static int SetearPrioridad(char operador)
        {
            if (operador == '+' || operador == '-') return 3;
            if (operador == '*' || operador == '/') return 2;
            if (operador == '(' || operador == ')') return 1;
            return 0;
        }
        public static void Main()
        {

            Stack<char> misOperadores = new Stack<char>();
            Stack<int> misValores = new Stack<int>();

            // Colocamos la expresión a ejecutar
            Console.WriteLine("Coloca tu expresión a ejecutar: Ejemplo(A+B*C || (a + b)*c)");
            string expresion = Console.ReadLine();
            // Asignamos los operadores según su jerarquía
            foreach (char c in expresion)
            {
                if (c == '(' || c == ')')
                {
                    SetearPrioridad(c);
                }
                else if (c == '*' || c == '/')
                {
                    SetearPrioridad(c);
                }

                else if (c == '+' || c == '-')
                {
                    SetearPrioridad(c);
                }
            }


            Console.WriteLine(misOperadores.Peek());
            //else if (char.IsLetter(c))
            //{
            //    Console.WriteLine($"Encontré variable: {c}");
            //}
        }


            // Asignamos los valores númericos a las variables A,B,C
            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine("Valor " + i);
            //    int valor = Int32.Parse(Console.ReadLine());
            //    // Agregamos el valor a la pila de misValores
            //    misValores.Push(valor);
            //}
            //Console.WriteLine()

    }
}

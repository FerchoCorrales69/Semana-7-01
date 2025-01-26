using System;
using System.Collections.Generic;

namespace BalanceoParentesis
{
    class Program
    {
        public static bool VerificarBalanceo(string expresion)
        {
            Stack<char> pila = new Stack<char>();

            foreach (char c in expresion)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    pila.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (pila.Count == 0)
                    {
                        return false;
                    }

                    char apertura = pila.Pop();

                    if ((c == ')' && apertura != '(') ||
                        (c == ']' && apertura != '[') ||
                        (c == '}' && apertura != '{'))
                    {
                        return false;
                    }
                }
            }

            return pila.Count == 0;
        }

        static void Main(string[] args)
        {
            // Título y Subtítulo
            Console.WriteLine("╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║                 UNIVERSIDAD ESTATAL AMAZÓNICA        ║");
            Console.WriteLine("║                    Fernando Corrales               ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");
            Console.WriteLine(); // Espacio en blanco

            string expresion1 = "{7+(8*5)-[(9-7)+(4+1)]}";
            string expresion2 = "{7+(8*5)-[(9-7)+(4+1]}";
            string expresion3 = "(7+8)";
            string expresion4 = "[(])";

            Console.WriteLine($"{expresion1} => {(VerificarBalanceo(expresion1) ? "Fórmula balanceada" : "Fórmula no balanceada")}");
            Console.WriteLine($"{expresion2} => {(VerificarBalanceo(expresion2) ? "Fórmula balanceada" : "Fórmula no balanceada")}");
            Console.WriteLine($"{expresion3} => {(VerificarBalanceo(expresion3) ? "Fórmula balanceada" : "Fórmula no balanceada")}");
            Console.WriteLine($"{expresion4} => {(VerificarBalanceo(expresion4) ? "Fórmula balanceada" : "Fórmula no balanceada")}");

            Console.ReadKey();
        }
    }
}
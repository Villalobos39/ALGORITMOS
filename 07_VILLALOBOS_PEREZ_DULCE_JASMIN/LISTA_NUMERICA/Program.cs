using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_NUMERICA
{
    class Program
    {
        static void Main(string[] args)
        {
            Random desorden = new Random();
            List<int> numeros = new List<int>(); string si;
            Console.Write("\n\t\bSUCESION NUMERICA\n");
            do { try {                  
                    for (int contar = 1; contar <=100; contar++)
                    {
                      
                        Console.Write(" {0} ", +contar); // numeros.Add(contar);  
                        numeros.Add(desorden.Next(1, 100));
                    }                    
                    Console.Write("\n"); numeros.Reverse();
                    foreach (int suscecion in numeros)
                    {
                        Console.Write("{0}", suscecion); Console.Write("||");                       
                    }   }
                catch (Exception) { Console.Write("\n\t\aERROR"); }
                Console.Write("\n\n\tNUMEROS : {0}", numeros.LongCount());              
                Console.Write("\n\t\tREINIZAR (SI || NO) : "); si = Console.ReadLine();
                numeros.Clear();
            }  while (si == "si" || si == "SI");  Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVERTIR
{
    class Program
    {
        static void Main(string[] args)
        {
           string si; int numero = 0; //ARTRIBUTOS 
            do
            {   try
                { //El uruario determina el numero de datos a ingrsar 
                    Console.Write("\n\t\bINVERTIR SUCESION"); 
                    Console.Write("\n\tINGRESE NUMERO DE CARACTERES : ");
                    numero = int.Parse(Console.ReadLine()); string[] sucesion = new string[numero];
                    for (int contar =sucesion.Length-1; contar >= 0; contar--)
                        {
                          Console.Write("\t{0}  : ", contar + 1); sucesion[contar]= Console.ReadLine();
                        }  sucesion.Reverse();
                    foreach (string suscecion in sucesion)
                    {
                        Console.Write(" {0} ", suscecion);
                    }
                    Console.Write("\nCARACTERES: {0} ", numero );
                }
                catch (ArgumentException) { Console.Write("\n\t\b\aERROR"); }
                Console.Write("\n\t\tREINIZAR (SI || NO) : "); si = Console.ReadLine();
            } while (si == "si" || si == "SI"); Console.ReadKey();
        }
    }
}

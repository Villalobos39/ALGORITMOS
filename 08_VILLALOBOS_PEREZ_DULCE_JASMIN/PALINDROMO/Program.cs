using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALINDROMO
{
    class Program
    {
        static void Main(string[] args)
        {  string si; int numeroPalindromo = 0;
            do
            {
                Console.Write("\n\tPALINDROMO\n");
                try
                {
                    Console.Write("\n\tINGRESE 5 DIGITOS : ");
                    numeroPalindromo = int.Parse(Console.ReadLine());

                    if (numeroPalindromo >= 10000 && numeroPalindromo <= 99999)
                    {
                        char[] reves = numeroPalindromo.ToString().ToCharArray();
                        int palindromoReves =int.Parse(Convert.ToString(reves[4]) +
                            Convert.ToString(reves[3]) + Convert.ToString(reves[2]) +
                            Convert.ToString(reves[1]) + Convert.ToString(reves[0]));
                        if (palindromoReves == numeroPalindromo)
                            Console.Write("\n\t{0} IGUAL {1} PALINDROMO\n", numeroPalindromo, palindromoReves);
                        else
                            Console.Write("\n\t{0} NO ES IGUAL {1} NO PALINDROMO\n", numeroPalindromo, palindromoReves);
                    }
                    else Console.Write("\t\aERRRO\n");
                }
                catch (FormatException) { Console.Write("\n\t\aLA CADENA DE DATOS NO TIENE EL FORMATO ASIGNADO\n"); }
                catch(OverflowException) { Console.Write("\n\t\aLA CADENA DE DATOS ESTA FUERA DEL RANGO ASIGNADO\n"); }
                finally { Console.Write("\n\t\tREINIZAR (SI || NO) : "); si = Console.ReadLine(); }
            }
            while (si == "si" || si == "SI"); Console.ReadKey();
        }
    }
}

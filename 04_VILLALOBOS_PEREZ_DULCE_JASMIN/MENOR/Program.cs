using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string si; int numero =3; //ATRIBUTOS 
            do { try {
                    Console.Write("\n\t\b>> MENOR <<\n");                 
                    double[] sucesion = new double[numero]; //VECTOR DE ALMACENAMIENTO
                    for (int contar = 0; contar < numero; contar++) 
                    {
                        Console.Write("\n\tINGRESE {0} ELEMENTO : ", contar + 1);
                        sucesion[contar] = double.Parse(Console.ReadLine());
                    }
                    Console.Write("\n\t EL ELEMENTO MENOR ES : {0}\n", sucesion.Min());
                } catch (FormatException) { Console.Write("\n\t\b\aERROR DE FORMATO\n");
                } Console.Write("\n\t\tRINIZAR (SI || NO) : "); si = Console.ReadLine();
            }  while (si == "si" || si == "SI"); Console.ReadKey();
        }
    }
}

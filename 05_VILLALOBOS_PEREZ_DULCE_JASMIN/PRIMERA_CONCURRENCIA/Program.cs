using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMERA_CONCURRENCIA
{
    class Program
    {
        static void Main(string[] args)
        {
            string si; int numero = 0; //ATRIBUTOS 
            do
            {
                try
                {
                    Console.Write("\n\t\b>> PRIMER ELEMENTO MAYOR <<\n");
                    Console.Write("INGRESE NUMERO DE ELEMENTOS :"); numero = int.Parse(Console.ReadLine());
                    double[] sucesion = new double[numero];
                    for (int contar = 0; contar < numero; contar++) //ALMACENO LOS DATOS EN EL VECTOR SUCESION
                    {
                        Console.Write("\n\tINGRESE {0} ELEMENTO : ", contar + 1);
                        sucesion[contar] = double.Parse(Console.ReadLine());
                    }
                    Console.Write("\n\t EL ELEMENTO MAYOR : {0}\n", (sucesion.ToList().IndexOf(sucesion.Max()) + 1));
                    Console.ReadKey(); // UTILIZO LA AYUDA DE LOS METODOS DE EXTENSION
                }
                catch (FormatException) //CACHO LOS ERRORES DE FORMATO QUE PODRIA INGRESAR EL USUARIO 
                {
                    Console.Write("\n\t\b\aERROR DE FORMATO\n");
                }
                Console.Write("\n\t\tREINIZAR (SI || NO) : "); si = Console.ReadLine();
            } while (si == "si" || si == "SI"); Console.ReadKey();
        }
    }
}

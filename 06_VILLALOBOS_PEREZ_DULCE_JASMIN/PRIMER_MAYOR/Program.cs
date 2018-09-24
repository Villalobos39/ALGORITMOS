using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMER_MAYOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string si; int numero = 0; //ARTRIBUTOS 
            do
            {
                try
                {
                    Console.Write("\n\t\bELEMENTO MAYOR DE LA SUCESION");
                    Console.Write("\n\tINGRESE NUMERO DE CARACTERES : ");
                    numero = int.Parse(Console.ReadLine());
                    string[] sucesion = new string[numero]; //VECTOR PARA ALMACENAR DATOS
                    for (int contar = 0; contar < sucesion.Length; contar++) //CON ESTO REALIZO UN CICLO PARA CAPTRUAR DATOS
                    {
                        Console.Write("\n\t{0}  : ", contar + 1); sucesion[contar] = Console.ReadLine();
                        Console.Write("\tCANTIDAD : {0}\n", sucesion[contar].LongCount());
                    }
                    for (int contador = 0; contador < sucesion.Length; contador++) // COMPARO LENGTH DE LOS ELEMENTOS CAPTURADOS
                    {
                        if (contador >= 1)
                        {
                            if (sucesion[contador].Length > sucesion[contador - 1].Length) // SI CUMPLEN LA CONDICION 
                            {
                                Console.Write("\nEl ELEMENTO MAYOR ES : {0} ", contador + 1);
                                contador = sucesion.Length;
                            }
                            else Console.Write("ORDEN DECRECIENTE ");
                        }
                    }
                    Console.Write("\n\n");
                    foreach (string ordenar in sucesion) { Console.Write("\t{0} ", ordenar); } //IMPRIME LA SUCESION 
                }
                catch (ArgumentException) { Console.Write("\n\t\b\aERROR"); } // CACHA SI SE PODRUCE ALGUN ERROR CON EL FORMATO
                Console.Write("\n\t\tREINIZAR (SI || NO) : "); si = Console.ReadLine();
            } while (si == "si" || si == "SI"); Console.ReadKey();
        }
    }
}

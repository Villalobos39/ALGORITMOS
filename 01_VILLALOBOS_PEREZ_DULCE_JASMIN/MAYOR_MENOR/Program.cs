using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAYOR_MENOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string si; int numero = 0; //ARTRIBUTOS 
            do
            {   try
                { //El uruario determina el numero de datos a ingrsar 
                    Console.Write("\n\t\b>>MAYOR O MENOR<<");
                    Console.Write("\n\tINGRESE DE CUANTOS NUMEROS SERA SU SUCESION : ");
                    numero = int.Parse(Console.ReadLine());
                    double[] sucesion = new double[numero];//El vector almecena eso datos 
                    for (int contar = 0; contar < numero; contar++)
                    {
                        Console.Write("\n\tINGRESE {0} VALOR : ", contar + 1);
                        sucesion[contar] = double.Parse(Console.ReadLine()); // ALMACENA LOS DATOS INGRESADOS POR EL USUARIO
                    }
                    Console.Write("\n\tEL VALOR MAYOR ES : {0:N} || EL VALOR MENOR ES : {1:N}\n", sucesion.Max(), sucesion.Min());                    
                }
                catch (FormatException) { Console.Write("\n\t\b\aLA CADENA DE DATOS NO TIENE EL FORMATO ASIGNADO\n"); }
                Console.Write("\n\t\tR  REINIZAR (SI || NO) : "); si = Console.ReadLine();// REINICIA EL CICLO HASTA QUE EL USUARIO LO DESIE 
            }
            while (si == "si" || si == "SI"); Console.ReadKey();
        }
    }
}

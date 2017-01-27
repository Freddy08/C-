using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leer_Cadena_y_Comparar
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            char[]dic = new char[17]{'0','1','2','3','4','5','6','7','8','9','+','-','*','/','(',')','='};
            Console.Write("Introducir la cadena: ");
            cadena = Console.ReadLine();
            int ciclo, veces;
            int total=0;
            for (veces = 0; veces < cadena.Length; veces++)
            {
                for (ciclo = 0; ciclo < 17; ciclo++)
                {
                    if (char.Parse(cadena.Substring(veces, 1)) == dic[ciclo])
                    {
                        //suma
                        total++;
                        break;
                    }
                }
            }
            if (total == cadena.Length)
            {
                Console.WriteLine("Cadena valida");
            }
            else {
                Console.WriteLine("Error Lexico");
            }
            Console.ReadLine();
        }
    }
}

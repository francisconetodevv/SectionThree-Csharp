using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecaoTres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Operadores lógicos: && (and)
             * True && True = True
             * True && False = False
             * False && True = False
             * False && False = True
             */
            
            /*
             * Operadores lógicos: || (Or)
             * True || True = True
             * True || False = True
             * False || True = True
             * False || False = False
             */

            // Convertendo o texto em número - O Console.ReadLine() lê sempre o valor na perspectiva de string
            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
            
            if (idade >= 2 && idade <= 13)
            {
                Console.WriteLine("A idade é de uma criança: " + idade);
            } else if (idade >= 14 && idade <= 25)
            {
                Console.WriteLine("A idade é de um adolescente: " + idade);
            } else if (idade >= 26 && idade <= 50)
            {
                Console.WriteLine("A idade é de um adulto: " + idade);
            } else
            {
                Console.WriteLine("A idade é de um idoso: " + idade);
            }
        }
    }
}
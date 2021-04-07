using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula29
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Treinamento - Aula29 , inserir dados, tipo int , float, double, 
             string, char , boolean */

            //Jonas Valereo - Técnico em Informática

            /*Declarando as variaveis tipo tipo int , float, double, 
             string, char , boolean */

            int x = 10;
            float y = 50f;
            double z = 20.0;
            char u = 'F';
            string nome = "Rafael";

            //imprimir saida de dados no console, método WhriteLine


            Console.WriteLine("Resultado da Informação:");
            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(u);
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(y.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));



            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa



        }
    }
}

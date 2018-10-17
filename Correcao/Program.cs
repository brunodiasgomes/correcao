using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao /* Aluno: Bruno Dias Gomes RA 31827615*/
{
    class Program
    {    /*Questão 01*/
        static int Maior(int a, int b) /*Primeira Forma*/
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
         /*Questão 01*/
        static int Maior2(int a, int b) /*Segunda Forma*/
        {
            return (a > b) ? a : b;
        }
          static void Main(string[] args)
        {
            Console.WriteLine(Maior(1, 2));
            Console.WriteLine(Maior2(3, 4));
            Console.ReadKey();
        }
        /*Questão 03*/
        static bool Par(int numero) /* Primeira Forma*/
        {
            int resto = numero % 2;
            if (resto == 0)
                return true;
            else
                return false;
        }
        /*Questão 03*/
        static string Par2(int numero) /* Segunda Forma*/
        {
            int resto = numero % 2;
            if (resto == 0)
                return "Par";
            else
                return "Ímpar";
        }
    }
}
            
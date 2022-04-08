using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quatro_1
{

    public delegate int meudelegado(int a, int b);
    public delegate void novodelegado(int a, int b, ref int rslt);
    class biblio
    {
        public static int fazTudo(int a, int b, meudelegado func)
        {
            return func(a, b);
        }
        public static IEnumerable<int> magica(int limite, Predicate<int> predicado)
        {
            
       
                for (int i = 1; i <= limite; i++)
                {
                    if (predicado(i)) yield return i;
                }
        }
           


        public static bool Elprimo(int num)
        {
            if (num < 2) return false;
            int quoc, div = 2, r;
            do
            {
                quoc = num / div;
                r = num % div++;

            } while(r!)
        }
        public static int multiplica(int x, int fator = 2)
        {
            return x * fator;
        }

        //numeros de variável de parametros
        public static somaN(params int[] numeros)
        {
           int soma = inicio;
            foreach (int pass in numeros) soma += pass);
            return soma;
        }

        public static int somaArray(int[] numeros) 
        {
            int soma = 0;
            for (int i = 0; i<;
        }
        
        public static int Troca (ref int x, ref int y)
        {
            int pivo = x;
            x = y;
            y = pivo;
        }
        public static void soma(int a, int b, out int rslt, out float media)
        {
            rslt = a + b;
            media =(float) (a + b) / 2.0f;


        }
    }
}

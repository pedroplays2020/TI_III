using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quatro_1
{
    class biblio
    {

        //classe struture enum interface~~
        //public delegate int 


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

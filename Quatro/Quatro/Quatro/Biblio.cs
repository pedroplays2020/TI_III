using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quatro
{
    //Classes Structure Delegates Enum Interface
    public delegate int nomedlg(int a, int b);
    public class Biblio
    {//parâmetro opcional - default parameter
        public static int soma(int x,int y) {
            return x + y;
        } 
        public static int  multiplica(int x, int fator = 2)
        {
            return x * fator;
        }

        //Número variável de parâmetros
        public static int somaN(int inicio, params int[] numeros)
        {
            int soma = inicio;
            foreach (int pass in numeros) soma += pass;
            return soma;
        }

        public static int somaArray(int[]numeros ) {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++) soma += numeros[i];
            return soma;
        }

        public void troca(ref int x,ref int y) {
            int pivot=x;
            x = y;
            y = pivot;
        }

        public static void soma(int a,int b, out int rslt, out float media)
        {
            rslt = a + b;
            media = (float)(a + b) / 2.0f;
        }
    }
}

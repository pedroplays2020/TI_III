using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dois
{
    //private protected internal public 

    public class Biblio
    {
        public static void selos(int euros)
        {
            int s5, s3, quoc, r;
            if (euros >= 8)
            {
                quoc = euros / 8;
                r = euros % 8;
                switch (r)
                {
                    case 0: { s5 = quoc; s3 = quoc; break; }
                    case 1: { s5 = quoc - 1; s3 = quoc + 2; break; }
                    case 2: { s5 = quoc + 1; s3 = quoc - 1; break; }
                    case 3: { s5 = quoc; s3 = quoc+1; break; }
                    case 4: { s5 = quoc-1; s3 = quoc+3; break; }
                    case 5: { s5 = quoc +1; s3 = quoc; break; }
                    case 6: { s5 = quoc; s3 = quoc +2; break; }
                    case 7: { s5 = quoc+2; s3 = quoc -1; break; }
                    default: { s5 = 0;s3 = 0; break; }
                }
            }
            else
            {
                if (euros == 3) { s5 = 0; s3 = 1; }
                else if (euros == 5) { s5 = 1; s3 = 0; }
                else if (euros == 6) { s5 = 0; s3 = 2; }
                else { s3 = 0; s5 = 0; Console.WriteLine("Devolve quantia"); }
            }
            Console.WriteLine("Selos cinco: {0} selos três:{1}", s5, s3);
        }//selos

        public static bool EPrimo(int num)
        {
            int quoc, r, div = 2;
            do {
                r = num % 2;
                quoc = num / div++;
                    
            } while (r!=0 && quoc >=div);
            return num == 2 || r != 0;
        }

        
        //métodos
        // Scope [static] returntype nome(ListaFormalde Parâmetros);{}
        public static int multiplica(int n,int fator=2)
        {
            return n * fator;
        }


        public static void soma(int x,int y, out int soma)
        {
            soma = x + y;
        }


    }//classe
}//namespace

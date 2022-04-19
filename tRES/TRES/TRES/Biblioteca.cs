using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRES
{
    public class Biblioteca
    {
        public static void selos(int euros)
        {
            int quoc, resto, s5, s3;

            try
            {
                if (euros >= 8)
                {
                    quoc = euros / 8;
                    resto = euros % 8;
                    switch (resto) {
                        case 0:s5 = quoc;s3 = quoc; break;
                        case 1: s5 = quoc-1;s3 = quoc+2; break;
                        case 2: s5 = quoc+1;s3 = quoc-1; break;
                        case 3: s5 = quoc;s3 = quoc+1; break;
                        case 4: s5 = quoc-1;s3 = quoc+3; break;
                        case 5: s5 = quoc+1;s3 = quoc; break;
                        case 6: s5 = quoc;s3 = quoc+2; break;
                        case 7: s5 = quoc+2;s3 = quoc-1; break;
                        default:s5 = 0;s3 = 0;break;
                    }
                }
                else {
                    if (euros == 3) { s5 = 0; s3 = 1; }
                    else if (euros == 5) { s5 = 1; s3 = 0; }
                    else if (euros == 6) { s5 = 0; s3 = 2; }
                    else { s5 = 0;s3 = 0; Console.WriteLine("Devolução da quantia: {0}", euros); }
                }
                Console.WriteLine("Euros:{0} Selos Cinco:{1}  Selos Três:{2}", euros, s5, s3);
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                
            }
        }

        public static int somaN(int limite)
        {
            int soma = 0;
            int n = 1;
            while (n<=limite) {
                //soma += n++;
                soma = soma + n;
                n = n + 1;
            }
            return soma;
        }

        public static bool EPrimo(int num)
        {
            int div = 2, quoc, r;
            if (num < 2) return false;
            div = 2;
            do {
                r = num % div;
                quoc = num / div++;
            } while (r != 0 && quoc >= div);
            return num == 2 || r != 0;
        }

        //scope private protected internal public
        //scope [static] tiporetorno nome (lista formal de parâmetros){}
        public int multiplica(int num)
        {
            return 2 * num;
        }
        public void dobro(int num, ref int rslt)
        {
            rslt = num * 2;
        }

        public static int menu() {
            int opcao = 0;
            do {
                Console.Clear();
                Console.Write("PROGRAMA DO ZÉ CARIOCA\n Menu\n");
                Console.WriteLine("\t1-Selos\n\t2-Primos\n\t3-Sair\n\t4-Dobro");
                Console.Write("\a\a\a\n:::::::::::::::\nEscolha Resposta:");
                if (!int.TryParse(Console.ReadLine(), out opcao)) {
                    opcao = -1;
                }
                
            } while (opcao <1 || opcao >4);

            return opcao;
        }
    }
}

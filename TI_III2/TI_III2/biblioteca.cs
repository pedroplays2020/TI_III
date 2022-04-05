using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_III2
{
    class biblioteca
    {
        public static void salario(int sb, )
        {
            

            if (sb >= 0 && sb <= 1000)
            {
                sl = sb - (sb * 0.5));
                tx = 0.5;
                dsc = sb * tx;

            }

            else if (sb > 1000 && sb < 1500)
            {
                sl = (sb - (sb * 0.15));
                tx = 0.15;
                dsc = sb * tx;

            }
                


            else if (sb > 1500 && sb < 2000)
                sl = sb - (sb * 0.23);
                tx = 0.23;


            else if (sb < +2000)
                sl = sb - (sb * 0.30);
                tx = 0.30;

            Console.WriteLine("salario bruto",sb);
            Console.WriteLine("salario liquido",sl);
            Console.WriteLine("desconto", dsc); 
            Console.WriteLine("taxa",tx);






        }
        {        public static int menu()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("progrma do zé careca\n menu");
                Console.WriteLine("1-Selos\n2-Primos\n3-Sair");
                Console.Write("\a\a\a\n:::::::::::::::\nEscolha Resposta:");
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = -1;
                }

            } while (opcao < 1 || opcao > 3);

            return opcao;
        }

        public static bool EPrimo(int num)
        {
            int div = 2, quoc, r;
            if (num < 2) return false;
            div = 2;
            do
            {
                r = num % div;
                quoc = num / div++;
            } while (r != 0 && quoc >= div);
            return num == 2 || r != 0;
        }

    }
}

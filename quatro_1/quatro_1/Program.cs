using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quatro_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((biblio.fazTudo(2, 3, biblio.soma))
        }

        static void Main(string[] args)
        {
            novodelegado action = (int a, int b, ref int rslt) =>
            {
                rslt = a + b;
                Console.Write("Soma de {0} + {1}= {2}", a, b, rslt);
            };
            int resultado = 0;
            action += (int a, int b, ref int rslt) =>
            {
                rslt += a * b;
                Console.Write("\nMultiplicação de {0} * {1}= {2}", a, b, a * b);
            };


            action(2, 3, ref resultado);

            Console.WriteLine("\nResultado final:" + resultado.ToString());
            Console.ReadLine();
            Console.Clear();
        }


        //Natureza multicasting
        //Passar métodos como argumentos
        //Ienumerable ->LINQ
    }
    static void Main(string[] args)
        {
            meudelegado func;
            int op1 = 3, op2 = 2;

            for (; ; )
            {
                Console.Write("+\n-\n*\n/\nEscolhaOpção:");
                String operacao = Console.ReadLine();
                switch (operacao)
                {
                    case "+":
                        func = biblio.soma;
                        break;
                    case "-":
                        //método anónimo
                        func = delegate (int a, int b) { return a - b; };
                        break;
                    case "*":
                        func = (a, b) => a * b;
                        break;
                    case "/":
                        func = (a, b) =>
                        {
                            b = (b == 0) ? 1 : b;
                            return a / b;
                        };
                        break;
                    default:
                        func = biblio.soma;
                        break;
                }

                Console.WriteLine(func(op1, op2));
                Console.ReadLine();
                Console.Clear();
            }


            //Natureza multicasting
            //Passar métodos como argumentos
            //Ienumerable ->LINQ
        }
        static void main(string[] args)
        {
            nomedlg nomedlg = biblio.soma;
            int rslt = Func(2.3);
            Console.WriteLine(rslt);
            Func= delegate(int a, int b)
            {
                return a * b;
            }
            Console.WriteLine(Func(2, 3));
            Func = (a, b) => a - b;
            Console.WriteLine(Func(2, 3));
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            int s = biblio.somaN(o, 21, 23, 24);
            
        }
        static void Main(string[] args) 
        {
            int[] xpto = new int[3];
            xpto[0] = 1;
            xpto[0] = 2;
            xpto[0] = 3;

            //int rsl = Class1.somaArray(new int[] { 1, 2, 3 });

            Console.WriteLine(rsl);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            Console.WriteLine("x={0}");
        }

        static void Main(string[] args)
        {
            int resultado = biblio.multiplica(3, 4);
        }

        static void Main(string[] args)
        {
            int s;
            float med;
            biblio.soma(1, 2 out s out med);
            Console
        }
    }
}

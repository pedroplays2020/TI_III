using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_III2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(" salrio bruto do utilizador");
            biblioteca.salario(int.Parse(Console.ReadLine());
            

        }

        
        // public static void Main(string[] args)
        //{
        //    int opcao;
        //    for (; ; )
        //    {
        //        try
        //        {
        //            opcao = biblioteca.menu();
        //            switch (opcao)
        //            {
        //                case 1:
        //                    //selos
        //                    Console.Write("Introduza quantia para selos:");
        //                    int quantia = int.Parse(Console.ReadLine());
        //                    biblioteca.selos(quantia);
        //                    Console.ReadLine();
        //                    break;
        //                case 2:
        //                    //primos
        //                    Console.Write("Introduza limite de primos:");
        //                    int limite = int.Parse(Console.ReadLine());
        //                    for (int c = 0, num = 2; c < limite; num++)
        //                    {
        //                        if (biblioteca.EPrimo(num))
        //                        {
        //                            Console.Write("{0}-", num);
        //                            c++;
        //                        }
        //                    }
        //                    Console.ReadLine();
        //                    break;
        //                case 3:
        //                    Console.WriteLine("Sair do Programa");
        //                    Console.ReadLine();
        //                    return;


        //            }
        //        }
        //        catch (Exception erro)
        //        {
        //            Console.WriteLine(erro.Message);

        //        }
        //        finally
        //        {

        //        }

        //    }

        //}


    }
}
            





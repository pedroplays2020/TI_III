using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace TRES
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            for (; ; ) {
                try
                {
                    opcao = Biblioteca.menu();
                    switch (opcao) {
                        case 1:
                            //selos
                            Console.Write("Introduza quantia para selos:");
                            int quantia = int.Parse(Console.ReadLine());
                            Biblioteca.selos(quantia);
                            Console.ReadLine();
                            break;
                        case 2:
                            //primos
                            Console.Write("Introduza limite de primos:");
                            int limite = int.Parse(Console.ReadLine());
                            for(int c = 0, num = 2; c < limite; num++)
                            {
                                if (Biblioteca.EPrimo(num))
                                {
                                    Console.Write("{0}-", num);
                                    c++;
                                }
                            }
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Sair do Programa");
                            Console.ReadLine();
                            return;
                        case 4:
                            Console.Write("Introduza número:");
                            int x = int.Parse(Console.ReadLine());
                            int rslt=0;
                            Biblioteca alfa = new Biblioteca();
                            alfa.dobro(x, ref rslt);
                            Console.WriteLine(rslt);
                            Console.ReadLine();
                            break;
                            

                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);

                }
                finally {
                    
                }

            }
            
        }
    }
}

#region lixo
//int n = 5;
//Biblioteca biblioteca = new Biblioteca();
//int rslt = 0;
//biblioteca.dobro(n, ref rslt);
//Console.WriteLine(rslt);
//Console.ReadLine();
//int limite;
//for (; ; )
//{
//    try
//    {
//        Console.Write("\n\n\a\aLimite:");
//        limite = int.Parse(Console.ReadLine());
//        if (limite < 0) break;
//        for (int i = 2, j = 0; j < limite; i++)
//        {
//            if (Biblioteca.EPrimo(i))
//            {
//                Console.Write("{0}-", i);
//                j++;
//            }
//        }
//    }
//    catch (Exception erro)
//    {

//        Console.Write(erro.Message);
//    }
//}

// while(true)
//{
//    int lim, rslt;
//    Console.Write("Limite:");
//    if (int.TryParse(Console.ReadLine(), out lim))
//    {
//        if (lim % 2 == 0) continue;
//        rslt = Biblioteca.somaN(lim);
//        Console.WriteLine("Soma:" +  rslt.ToString());
//    }
//    else {

//        Console.WriteLine("Erro");
//        break;
//    }
//}

//int quantia;
//do {
//    Console.Write("Introduza quantia:");
//    if (int.TryParse(Console.ReadLine(), out quantia)){
//        Biblioteca.selos(quantia);
//    }
//    else {
//        Console.WriteLine("Quantia inválida");
//    }
//} while (quantia >= 0);
//Console.WriteLine("Desligando  máquina...\a\a\a\a");
//Thread.Sleep(3200);

#endregion
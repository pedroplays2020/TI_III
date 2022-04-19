using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dois
{
    class Program
    {
        static void Main(string[] args)
        {
            int rslt;
            Biblio.soma(2, 3, out rslt);
            Console.WriteLine(rslt);
            Console.Read();
        }
    }
}





//int dobro = Biblio.multiplica(3);
//Console.WriteLine("Dobro:{0}", dobro);
//int fat = 3;
//int triplo = Biblio.multiplica(3, fat);
//Console.WriteLine("Dobro:{0}", triplo);

//for (; ; )
//{
//    try
//    {
//        Console.Write("\n\n\a\a\aIntroduza Limite:");
//        int limite = int.Parse(Console.ReadLine());
//        if (limite < 0) break;
//        for(int n=2,c=0; c < limite; n++)
//        {
//            //if (n == 2) continue;
//            if (Biblio.EPrimo(n)) {
//                Console.Write("{0}:", n);
//                c++;
//            }
//        }

//    }
//    catch (Exception erro)
//    {

//        Console.WriteLine(erro.Message);
//    }
//}

//    int y, x = 2;
//    y = (x % 2 == 0) ? 1:2;


//    //Biblio biblio = new Biblio();
//    int quantia;
//    for(; ; )
//    {
//        try
//        {
//            Console.Write("Introduza euros:");
//            quantia = int.Parse(Console.ReadLine());
//            Biblio.selos(quantia);
//            if (quantia < 0) break;
//        }
//        catch (Exception erro)
//        {

//            Console.WriteLine("\a\a\a" + erro.Message);
//        }
//        finally {
//            Console.WriteLine("Finally");
//        }
//    }
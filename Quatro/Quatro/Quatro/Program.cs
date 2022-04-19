using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quatro
{
    class Program
    {
        static void Main(string[] args)
        {
            //nomedlg func = new nomedlg(Biblio.soma);
            nomedlg func = Biblio.soma;
            int rslt = func(2,3);
            Console.WriteLine(rslt);

            func = delegate (int a, int b) { return a * b; };
            Console.WriteLine(func(2, 3));
            //lambda
            func = (a, b) =>  a - b;
            Console.WriteLine(func(2, 3));
            Console.ReadLine();

            //Natureza multicasting
            //Passar métodos como argumentos
            //Ienumerable ->LINQ
        }
    }
}

//int s;
//float med;
//Biblio.soma(1, 2, out s, out med);
//Console.WriteLine("Soma={0} Média={1:F2}", s, med);

//Biblio biblio = new Biblio();
//int x=1 , y = 2;
//Console.WriteLine("x={0} y={1}", x, y);
//biblio.troca(ref x,ref y);
//Console.WriteLine("x={0} y={1}", x, y);
//int[] xpto = new int[3];
//xpto[0] = 1;
//xpto[1] = 2;
//xpto[2] = 3;
//// int rslt = Biblio.somaArray(new int[] {1,2,3});
//int rslt = Biblio.somaArray(xpto);
//Console.WriteLine(rslt);

//int s = Biblio.somaN(0, 21, 23, 24);
//Console.WriteLine(s);
//Console.WriteLine(Biblio.somaN(0,1,2));
//int resultado = Biblio.multiplica(3, 4);

//Console.WriteLine(resultado);
//resultado = Biblio.multiplica(7);
//Console.WriteLine(resultado);
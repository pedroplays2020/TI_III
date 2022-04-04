using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_III2
{
    class Program
    {
        static void Main(string[] args)
        {
            int limite;
            for (; ; )
            {
                try
                {
                    Console.Write("limite: ");
                    limite = int.Parse(Console.ReadLine());
                    if (limite < 0) break;
                    for (int i = 2, j = 0; j < limite; i++)
                    {
                        if (biblioteca.EPrimo(i))
                        {
                            Console.Write("{0}-", i);
                            j++;
                        }
                    }
                }
                catch (Exception erro)
                {

                }
                Console.ReadLine();
            }

        }
    }
    
}

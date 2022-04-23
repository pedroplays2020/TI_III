using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinco
{
    class Program
    {
        static void Main(string[] args)
        {
            Viatura.partida();
            Viatura ford = new Viatura("Ford","G40");

            ford.Velocidade = 12;

            ford.mostrador();

            Console.ReadLine();
        }
    }
}


//ford.mostrador();
//Viatura fiat = new Viatura("Fiat", "Fiat 600");
////desreferenciar o objeto da memória que ocupava
//fiat.mostrador();

//ford = null;


//GC.Collect();
//GC.WaitForPendingFinalizers();
//fiat.mostrador();
//
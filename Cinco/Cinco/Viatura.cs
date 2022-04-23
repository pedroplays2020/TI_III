using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinco
{
    public class Viatura
    {
        public static int total;
        public const int MAXVEL = 120; 
        //campos
        private String _marca;
        public String Marca {
            get
            {
                return _marca;
            }
        }

        private String _modelo;

        public String Modelo
        {
            get
            {
                return _modelo;
            }
        }
        protected int _velocidade;
        public int Velocidade
        {
            get {
                return _velocidade;
            }
            set {
                if (value >= 0) _velocidade = value;
            }
        }


        public static void partida()
        {
            Console.WriteLine("------------Partida-------------");
        }
        public void mostrador()
        {
            Console.WriteLine("---------------("+  _modelo +")---------------");
            Console.WriteLine("Velocidade Máxima:" + Viatura.MAXVEL.ToString());
            Console.WriteLine(String.Format("Marca:{0} Velocidade:{1}", _marca, _velocidade));
            Console.WriteLine("Total: " + Viatura.total.ToString());
            Console.WriteLine("-------------------------------------");
        }

        //overloading
        public Viatura(string marca, string modelo)
        {
            Viatura.total++;
            this._marca = marca;
            this._modelo = modelo;
        }
        public Viatura(string marca, string modelo, int velocidade):this(marca,modelo)
        {
            this._velocidade = velocidade;
        }
        //override
        public override string ToString()
        {
            return "Marca:" + _marca + "  Modelo:" + _modelo + "  Velocidade:" + _velocidade.ToString();
        }

        ~Viatura()
        {
            Viatura.total--;
            Console.WriteLine("Destrutor da viatura " + this._modelo);
        }
    }
}

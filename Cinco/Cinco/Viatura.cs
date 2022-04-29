using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinco
{
    //interface - eventos - extension methods
    public enum MULTAS:int
    {
        LEVE=100,
        MÉDIA=150,
        GRAVE=1000
    }

    public struct Motor
    {
        public string ModeloMotor { get; set; }
        public int Cilindrada;
        public int Potencia;
        public Motor(string modelomotor, int cilindrada, int potencia)
        {
            ModeloMotor = modelomotor;
            Cilindrada = cilindrada;
            Potencia = potencia;
        }
    }

    public abstract class Viatura
    {
        public static int total;
        public const int MAXVEL = 120;
        public Motor MyMotor { get; set; }

        public abstract void encherTanque();
        
        #region campos e propriedades
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

        #endregion


        public static void partida()
        {
            Console.WriteLine("------------Partida-------------");
            Console.WriteLine(MULTAS.LEVE + "->" + ((int)MULTAS.LEVE).ToString());
            Console.WriteLine(MULTAS.MÉDIA + "->" + ((int)MULTAS.MÉDIA).ToString());
            Console.WriteLine(MULTAS.GRAVE + "->" + ((int)MULTAS.GRAVE).ToString());
        }
        public virtual void mostrador()
        {
            Console.WriteLine("---------------("+  _modelo +")---------------");
            Console.WriteLine("Velocidade Máxima:" + Viatura.MAXVEL.ToString());
            Console.WriteLine(String.Format("Marca:{0} Velocidade:{1}", _marca, _velocidade));
            Console.WriteLine("Total: " + Viatura.total.ToString());
            Console.WriteLine(String.Format("Modelo Motor:{0} Cilindrada:{1} Potência:{2}",MyMotor.ModeloMotor,MyMotor.Cilindrada, MyMotor.Potencia));
        }


        #region construtores e destrutor
        //overloading
        public Viatura(string marca, string modelo, Motor motor)
        {
            Viatura.total++;
            this._marca = marca;
            this._modelo = modelo;
            this.MyMotor = motor;

        }
        public Viatura(string marca, string modelo, int velocidade, Motor motor):this(marca,modelo,motor)
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
        #endregion
    }

    public sealed class Carro : Viatura
    {

        public override void encherTanque()
        {
            Tanque += (Tanque + 50 <= 100) ? 50 : 0; 
        }
        public override void mostrador()
        {
            base.mostrador();
            Console.WriteLine("Tanque:" + Tanque.ToString());
            Console.WriteLine("----------------------------------------");
        }
        public int Tanque { get; set; }
        public Carro(string marca, string modelo, Motor motor) : base(marca, modelo, motor)
        {
            Random r = new Random();
            Tanque = r.Next(0, 101);
        }

        public Carro(string marca, string modelo, int velocidade, Motor motor) : base(marca, modelo, velocidade, motor)
        {
            Random r = new Random();
            Tanque = r.Next(0, 101);
        }
    }
}

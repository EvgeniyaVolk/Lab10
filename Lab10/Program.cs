using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Injection injection = new Injection();
            Console.WriteLine("Введите значение градуса:");
            injection.Gradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение минуты:");
            injection.Min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение секунды:");
            injection.Sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение угла в радианах:");
            Console.WriteLine(Injection.ToRadians(injection.Gradus));
            Console.ReadKey();
        }
    }
    class Injection
    {

        private int gradus;
        private int min;
        private int sec;

        public int Gradus
        {
            set
            {
                if (value >= 0 && value <= 360)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Введите верное число gradus от 0 до 360");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Введите верное число min от 0 до 60");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Введите верное число sec от 0 до 60");
                }
            }
            get
            {
                return sec;
            }
        }
      
        public void minMeter()
        {
            Console.WriteLine("Значение угла в минутах= {0}", Gradus / 60+Min+Sec/60);
        }

        public void secMeter()
        {
            Console.WriteLine("Значение угла в секундах= {0}", Gradus / 3600+Min/60+Sec);
        }
        /* public Injection(int gradus, int min, int sec)
          {
              Gradus = gradus;
              Min = min;
              Sec = sec;
          }*/

        public static double ToRadians(double angle)
        {
            return angle * Math.PI / 180;
        }


    }

}

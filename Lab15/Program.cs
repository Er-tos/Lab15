using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание арифметической прогрессии.");
            Console.WriteLine("Задайте начальное значение прогрессии.");
            int arProgrStart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте шаг прогрессии.");
            int arProgrStep = Convert.ToInt32(Console.ReadLine());
            arithmeticProgression arProgr = new arithmeticProgression(arProgrStart, arProgrStep);
            Console.WriteLine("Последующий член арифметической прогрессии равен: {0}", arProgr.getNext());
            Console.WriteLine("Последующий член после него равен: {0}", arProgr.getNext());
            Console.WriteLine("Последующий член после предыдущего равен: {0}", arProgr.getNext());
            arProgr.reset();
            Console.WriteLine("После сброса последующее значение прогрессии снова равно: {0}", arProgr.getNext());
            Console.WriteLine();
            Console.WriteLine("Создадие геометрической прогрессии.");
            Console.WriteLine("Введите начальное значение прогрессии.");
            int geoProgrStart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте шаг прогрессии.");
            int geoProgrStep = Convert.ToInt32(Console.ReadLine());
            geometricProgression geoProgr = new geometricProgression(geoProgrStart, geoProgrStep);
            Console.WriteLine("Последующий член геометрической прогрессии равен: {0}", geoProgr.getNext());
            Console.WriteLine("Последующий член после него равен: {0}", geoProgr.getNext());
            Console.WriteLine("Последующий член после предыдущего равен: {0}", geoProgr.getNext());
            geoProgr.reset();
            Console.Write("После сброса последующее значение прогрессии снова равно: {0}", geoProgr.getNext());
            Console.ReadKey();
        }
        interface ISeries
        {
            void setStart(int x);
            int getNext();
            void reset();
        }
        class arithmeticProgression : ISeries
        {
            int value = 0;
            int firstValueDefault = 0;
            int step = 0;
            public void setStart(int x)
            {
                value = x;
                firstValueDefault = x;
            }
            public void setStep(int s)
            {
                step = s;
            }
            public int getNext()
            {
                value = value + step;
                return value;
            }
            public void reset()
            {
                value = firstValueDefault;
            }
            public arithmeticProgression(int x, int s)
            {
                value = x;
                firstValueDefault = x;
                step = s;
            }
        }
        class geometricProgression : ISeries
        {
            int value = 0;
            int firstValueDefault = 0;
            int step = 0;
            public void setStart(int x)
            {
                value = x;
                firstValueDefault = x;
            }
            public void setStep(int s)
            {
                step = s;
            }
            public int getNext()
            {
                value = value * step;
                return value;
            }
            public void reset()
            {
                value = firstValueDefault;
            }
            public geometricProgression(int x, int s)
            {
                value = x;
                firstValueDefault = x;
                step = s;
            }
        }
    }
}

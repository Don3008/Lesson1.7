using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfCircleRandomCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* R0 - радиус окружности, которую мы задаем
             * x0, y0 - координаты центра окружности
             * x, y - координаты точки, которую нужно проверить
             * s - сумма квадратов координат
             */
            double x0, y0, x, y, R0, s;
            Console.Write("Введите радиус \"R\" вашей окружности: ");
            R0 = Convert.ToDouble(Console.ReadLine());
            if (R0 >= 0)
            {
                Console.Write("Введите координату \"x0\" центра вашей окружности: ");
                x0 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату \"y0\" центра вашей окружности: ");
                y0 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату \"x\" вашей точки: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату \"y\" вашей точки: ");
                y = Convert.ToDouble(Console.ReadLine());
                s = Math.Pow((x0 - x), 2) + Math.Pow((y0 - y), 2);
                if (Math.Pow(R0, 2) < s)
                {
                    Console.WriteLine("Точка с координатами x = " + x + "; y = " + y + " находится за пределами окружности");
                }
                else if (Math.Pow(R0, 2) == s)
                {
                    Console.WriteLine("Точка с координатами x = " + x + "; y = " + y + " находится на окружности");
                }
                else
                {
                    Console.WriteLine("Точка с координатами x = " + x + "; y = " + y + " находится внутри окружности");
                }
            }
            else
            {
                Console.WriteLine("Радиус должен быть положительным!");
            }
        }
    }
}

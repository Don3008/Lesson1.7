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
            /* initRadius - радиус окружности, которую мы задаем
             * initCoordinateX, initCoordinateY - координаты центра окружности
             * coordinateOfPointX, coordinateOfPointY - координаты точки, которую нужно проверить
             * sumOfSquares - сумма квадратов координат
             * radiusOfSquare - радиус окружности в квадрате
             */
            double initCoordinateX, initCoordinateY, coordinateOfPointX, coordinateOfPointY, initRadius, sumOfSquares, radiusOfSquare;
            Console.Write("Введите радиус \"R\" вашей окружности: ");
            initRadius = Convert.ToDouble(Console.ReadLine());
            if (initRadius >= 0)
            {
                Console.Write("Введите координату \"initCoordinateX\" центра вашей окружности: ");
                initCoordinateX = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату \"initCoordinateY\" центра вашей окружности: ");
                initCoordinateY = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату \"coordinateOfPointX\" вашей точки: ");
                coordinateOfPointX = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату \"coordinateOfPointY\" вашей точки: ");
                coordinateOfPointY = Convert.ToDouble(Console.ReadLine());
                radiusOfSquare = Math.Pow(initRadius, 2);
                sumOfSquares = Math.Pow((initCoordinateX - coordinateOfPointX), 2) + 
                Math.Pow((initCoordinateY - coordinateOfPointY), 2);
                if (radiusOfSquare < sumOfSquares)
                {
                    Console.WriteLine("Точка с координатами coordinateOfPointX = " + coordinateOfPointX + "; " +
                        "coordinateOfPointY = " + coordinateOfPointY + " находится за пределами окружности");
                }
                else if (radiusOfSquare == sumOfSquares)
                {
                    Console.WriteLine("Точка с координатами coordinateOfPointX = " + coordinateOfPointX + 
                        "; coordinateOfPointY = " + coordinateOfPointY + " находится на окружности");
                }
                else
                {
                    Console.WriteLine("Точка с координатами coordinateOfPointX = " + coordinateOfPointX + 
                        "; coordinateOfPointY = " + coordinateOfPointY + " находится внутри окружности");
                }
            }
            else
            {
                Console.WriteLine("Радиус должен быть положительным!");
            }
        }
    }
}

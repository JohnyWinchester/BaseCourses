using System;

namespace DZ03AndreyMatveew
{
    /* Матвеев Андрей. Задача № 3. 
    Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
    по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, 
    используя спецификатор формата .2f (с двумя знаками после запятой);
    */
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 2.2;
            double y1 = 3.2;
            double x2 = 10.2;
            double y2 = 8.2;
            Console.WriteLine("{0:F2}", Distance(x1,y1,x2,y2));

            Console.ReadKey();
        }
        //Метод расчёта дистанции 
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}

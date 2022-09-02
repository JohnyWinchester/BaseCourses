using System;

namespace DZ0601AndreyMatveew
{
    /* Матвеев Андрей. Задача 1.
    Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
    Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
    */
    public delegate double Fun(double x, double y);
    class Program
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b,double y)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,y));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x, double y)
        {
            return y * Math.Pow(x,2);
        }

        public static double MyFuncSin(double x, double y)
        {
            return y * Math.Sin(x);
        }

        static void Main()
        {
            //Продемонстрировать работу на функции с функцией a* x^2
            Console.WriteLine("Таблица функции MyFunc:");
            Table(MyFunc, -2, 2,2);

            //Продемонстрировать работу на функции с функцией a*sin(x)
            Console.WriteLine("Таблица функции MyFuncSin:");
            Table(MyFuncSin, -2, 2, 2);

            Console.ReadKey();
        }
    }
}
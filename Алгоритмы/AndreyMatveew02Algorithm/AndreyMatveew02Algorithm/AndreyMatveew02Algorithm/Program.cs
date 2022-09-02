using System;

namespace AndreyMatveew02Algorithm
{
    //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 02.
    //** Исполнитель «Калькулятор» преобразует целое число, записанное на экране.У
    // исполнителя две команды, каждой присвоен номер:
    //1. Прибавь 1.
    //2. Умножь на 2.
    //Первая команда увеличивает число на экране на 1, вторая увеличивает его в 2 раза.Сколько
    //существует программ, которые число 3 преобразуют в число 20:
    //b. * С использованием рекурсии
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 20;
            ReversСalculator(a, b, a.ToString());

            Console.ReadKey();
        }
        static void ReversСalculator(int a, int b, string str)
        {
            for (int i = 0; i < 2; i++)
            {
                string s = str;
                int n = a;
                if (i == 0)
                {
                    n++;
                    s += "+1";
                }
                else
                {
                    n *= 2;
                    s += "*2";
                }
                if (n < b) ReversСalculator(n, b, s);
                else
                    if (n == b) Console.WriteLine(s + "=" + b);
            }
        }
    }
}

using System;
using System.Linq;

namespace AndreyMatveew02Algorithm1

{   //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 02.
    //Реализовать функцию перевода чисел из десятичной системы в двоичную, используя
    //рекурсию.
    class Program
    {
        static void Main(string[] args)
        {
            BinaryNotation(113, 2, new string(""));
            Console.ReadKey();
        }
        public static void BinaryNotation(int num,int denominator,string binaryNum )
        {
            int n = num / denominator;
            binaryNum += num % denominator;
            if(n == 1 || n == 0)
            {
                Console.WriteLine(new string((binaryNum + num / denominator).ToCharArray().Reverse().ToArray()));
                return;
            }

            BinaryNotation(n, denominator, binaryNum);
        }
    }
}

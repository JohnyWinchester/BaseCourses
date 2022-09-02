using System;
using System.Collections.Generic;

namespace AndreyMatveew01Algorithm
{
    //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 01.
    //Задание 14.* Автоморфные числа. Натуральное число называется автоморфным, если оно равно последним
    //цифрам своего квадрата.Например, 25 \ :sup: `2` = 625. Напишите программу, которая вводит
    //натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N: ");
            AmorphNumber(Int32.Parse(Console.ReadLine()));
            Console.ReadKey();
        }

        /// <summary>
        ///  Выводит на экран все автоморфные числа, не превосходящие N.
        /// </summary>
        public static void AmorphNumber(int number)
        {
            for (long i = 5; i < number; i++)
            {
                if(i*i % Math.Pow(10,AmountNumbers((int)i)) == i)
                    Console.WriteLine($"{i} - {i * i}");
            }
        }

        /// <summary>
        ///  Считает количество цифр в числе
        /// </summary>
        public static int AmountNumbers(int number)
        {
            int amountNum = 0;
            while(number > 0)
            {
                var remainder = number % 10;
                number = (number - remainder) / 10;
                amountNum++;
            }
            return amountNum;
        }
    }
}

using System;

namespace DZ0302AndreyMatveew
{
    class Program
    {
        /* Матвеев Андрей. Задача № 2. 
         С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
         Требуется подсчитать сумму всех нечётных положительных чисел.
         Сами числа и сумму вывести на экран, используя tryParse.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа. Если хотите закончить введите 0");
            Console.WriteLine(SumNumbers());
            Console.ReadKey();
        }

        public static int SumNumbers()
        {
            int sumNum = 0;
            string number = Console.ReadLine();

            do
            {
                while (!int.TryParse(number, out int x))
                {
                    Console.WriteLine("Неверный формат.Введите число: ");
                    number = Console.ReadLine();
                }

                if (Int32.Parse(number) > 0 && Int32.Parse(number) % 2 > 0)
                {
                    sumNum += Int32.Parse(number);
                }
                number = Console.ReadLine();

            } while (number != "0");

            return sumNum;
        }
    }
}

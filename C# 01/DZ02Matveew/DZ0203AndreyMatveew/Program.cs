using System;

namespace DZ0203AndreyMatveew
{
    /* Матвеев Андрей. Задача № 3. 
    С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumNumbers());
            Console.ReadKey();
        }

        public static int SumNumbers()
        {
            int sumNum = 0;
            string number = Console.ReadLine();

            while (number != "0")
            {
                sumNum += Int32.Parse(number);
                number = Console.ReadLine();
            }

            return sumNum;
        }
    }
}

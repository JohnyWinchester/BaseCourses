using System;

namespace DZ0202AndreyMatveew
{
    /* Матвеев Андрей. Задача № 2. 
    Написать метод подсчета количества цифр числа.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AmountNumbers(111));
            Console.ReadKey();
        }

        public static int AmountNumbers(int number)
        {
            int i = 0;
            while (number > 0)
            {
                i++;
                number /= 10;
            }

            return i;
        }
    }
}

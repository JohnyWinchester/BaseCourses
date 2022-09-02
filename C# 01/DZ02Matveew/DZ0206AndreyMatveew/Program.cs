using System;

namespace DZ0206AndreyMatveew
{
    class Program
    {
        /* Матвеев Андрей. Задача № 6. 

        */
        static void Main(string[] args)
        {
            DateTime timerStart = DateTime.Now;
            Console.WriteLine(timerStart);

            GoodNumbers();

            Console.WriteLine("\n{}", DateTime.Now - timerStart);
            Console.ReadKey();
        }

        public static void GoodNumbers()
        {
            int goodNumbers = 0;
            int firstNum = 1;
            int lastNum = 1000000;
            int temp = 0;
            int thisNum = 0;

            for (int i = firstNum; i <= lastNum; i++)
            {
                temp = 0;
                thisNum = i;
                while (thisNum != 0)
                {
                    temp += thisNum % 10;
                    thisNum /= 10;
                }
                if (i % temp == 0) goodNumbers++;
            }

            Console.WriteLine("\nКоличество хороших чисел {0}", goodNumbers);
        }
    }
}

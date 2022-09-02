using System;

namespace DZ0201AndreyMatveew
{
    /* Матвеев Андрей. Задача № 1. 
    Написать метод, возвращающий минимальное из трёх чисел.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxNumber(10, 2, 3));

            Console.ReadKey();
        }

        public static int MaxNumber(int firstNum,int secondNum,int thirdNum)
        {
            int maxNum = Math.Min(firstNum,secondNum) == firstNum ? Math.Min(firstNum,thirdNum) == firstNum ? maxNum = firstNum 
                         : maxNum = thirdNum 
                         : Math.Min(secondNum, thirdNum) == secondNum ?  maxNum = secondNum : maxNum = thirdNum;
            return maxNum;
        }
    }
}

using System;

//Матвеев Андрей. Задача № 4 Написать программу обмена значениями двух переменных:

namespace DZ04AndreyMatveew
{
    class Program
    {
        static void Main(string[] args)
        {
            // а) с использованием третьей переменной;

            //int x = 1;
            //int y = 2;
            //Console.WriteLine("x:" + x + " y:" + y);
            //int reverse = 0;
            //reverse = x;
            //x = y;
            //y = reverse;
            //Console.WriteLine("x:" + x + " y:" + y);

            // б) *без использования третьей переменной.
            int x = 1;
            int y = 2;
            Console.WriteLine("x:" + x + " y:" + y);

            unsafe
            {
                SwapVariables(&x, &y);
            }
            Console.WriteLine("x:" + x + " y:" + y);

            Console.ReadKey();
        }

        unsafe static void SwapVariables(int* x,int* y) 
        {
            unsafe
            {
                *x ^= *y;
                *y ^= *x;
                *x ^= *y;
            }
        }
    }
}

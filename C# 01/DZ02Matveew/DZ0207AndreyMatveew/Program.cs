using System;

namespace DZ0207AndreyMatveew
{
    /* Матвеев Андрей. Задача № 7. 
    a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Numbers(3, 10);
            Console.WriteLine($"\nВывод рекурсивного метода, который считает сумму чисел от a до b: {NumbersSumm(1,4,0)}");
            Console.ReadKey();
        }

        public static void Numbers(int first,int last)
        {
            if(first <= last)
            {
                Console.WriteLine(first);
                Numbers(first + 1, last);
            }
        }

        public static int NumbersSumm(int first,int last,int summ)
        {
            if (first <= last)
            {
                summ += first;
                first++;
                summ = NumbersSumm(first, last,summ);
            }
            return summ;
        }
    }
}

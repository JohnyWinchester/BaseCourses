using System;
using MyStructures;

namespace AndreyMatveew05Algorithm
{
    //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 05.
    //Задание 1.Реализовать перевод из десятичной в двоичную систему счисления с использованием стека
    class Program
    {
        static void Main(string[] args)
        {
            var binaryNumber = DoubleConversion(486);
            foreach(var el in binaryNumber)
            {
                Console.Write(el);
            }
            Console.ReadKey();
        }
        public static MyStack<int> DoubleConversion(int number)
        {
            MyStack<int> modulo = new();
            while(number > 0)
            {
                modulo.Push(number - ((number / 2) * 2));
                number /= 2;
            }
            return modulo;
        }
    }
}

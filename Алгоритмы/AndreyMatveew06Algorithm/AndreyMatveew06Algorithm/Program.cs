using System;
using HashLib;

namespace AndreyMatveew06Algorithm
{
    class Program
    {
        //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 06.
        //Задание 1. Реализовать простейшую хэш-функцию. На вход функции подается строка, на выходе сумма кодов символов.

        static void Main(string[] args)
        {
            //Использована библиотека HashLib
            var str = "test";
            var sha3 = HashFactory.Crypto.SHA3.CreateKeccak512();
            var tempHash = sha3.ComputeString(str);

            Console.WriteLine($"Original string: {str} \n\nSHA3-512: {tempHash}");
        }
    }
}

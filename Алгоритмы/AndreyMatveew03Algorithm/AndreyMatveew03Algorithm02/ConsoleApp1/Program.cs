using System;

namespace ConsoleApp1
{
    //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 03.
    //Задание 2.* Реализовать шейкерную сортировку.
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[10] { 3, 2, 4, 5, 10, 25, 33, 8, 44, 10 };
            ArrayPrint(array);

            array = ShakerSort(array);
            ArrayPrint(array);

            Console.ReadKey();
        }

        public static int[] ShakerSort(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var flag = false;
                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        flag = true;
                    }
                }

                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        flag = true;
                    }
                }

                if (!flag)
                {
                    break;
                }
            }
            return array;
        }
        public static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        public static void ArrayPrint(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }
        }
    }
}

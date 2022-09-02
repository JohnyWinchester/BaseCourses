using System;

namespace AndreyMatveew08Algorithm
{
    //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 08.
    //Проанализировать время работы каждого из вида сортировок для 100, 10000, 1000000 элементов.Заполнить таблицу
    class Program
    {
        static void Main(string[] args)
        {
            //Открывайте Excel файл .....AndreyMatveew08Algorithm\AndreyMatveew08Algorithm\bin\Debug\net5.0
            var arrays = GenerateArrays();
            ExcelStatisticsFile statisticsFile = new(arrays[0],arrays[1],arrays[2]);
        }
        public static int[][] GenerateArrays()
        {
            var arrays = new int[3][];
            arrays[0] = new int[100];
            arrays[1] = new int[10000];
            arrays[2] = new int[1000000];

            Random random = new();

            for (int i = 0; i < 100;i++)
            {
                arrays[0][i] = random.Next(0, 100);
            }

            for (int i = 0; i < 10000; i++)
            {
                arrays[1][i] = random.Next(0, 100);
            }

            for (int i = 0; i < 1000000; i++)
            {
                arrays[2][i] = random.Next(0, 100);
            }
            return arrays;
        }
    }
}

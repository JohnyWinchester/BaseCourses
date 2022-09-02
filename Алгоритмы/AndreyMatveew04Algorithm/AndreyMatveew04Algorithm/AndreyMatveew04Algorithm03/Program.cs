using System;

namespace AndreyMatveew04Algorithm03
{
    //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 04.
    //Задание 3. ***Требуется обойти конём шахматную доску размером NxM,
    //пройдя через все поля доски по одному разу.
    //Здесь алгоритм решения такой же как и в задаче о 8 ферзях.
    //Разница только в проверке положения коня.
    class Program
    {
        static void Main(string[] args)
        {
            HorseAlgorithm horse = new HorseAlgorithm(5, 5);
            horse.SearchSolution(1,(0,0));

            Console.ReadKey();
        }
    }
}

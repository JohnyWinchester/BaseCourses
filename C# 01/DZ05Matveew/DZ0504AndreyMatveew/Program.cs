using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace DZ0504AndreyMatveew
{

    /* Матвеев Андрей. Задача 4. 
    *Задача ЕГЭ.
    На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
    В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100,
    каждая из следующих N строк имеет следующий формат:
    <Фамилия> <Имя> <оценки>,
    где <Фамилия> — строка, состоящая не более чем из 20 символов, 
    <Имя> — строка, состоящая не более чем из 15 символов, 
    <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. 
    <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
    Иванов Петр 4 5 3
    Требуется написать как можно более эффективную программу,
    которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
    Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, 
    следует вывести и их фамилии и имена.
    */
    class Program
    {
        static void Main(string[] args)
        {
            PupilsRaiting();
            Console.ReadKey();
        }

        public static void PupilsRaiting()
        {
            StreamReader reader = new StreamReader(@"E:\GeekBrains\C# 01\DZ05Matveew\DZ0504AndreyMatveew\MyClass.txt");
            int amountPupils = int.Parse(reader.ReadLine());
            List<Pupil> pupils = new List<Pupil>();

            Console.WriteLine("Всего учеников: " + amountPupils);
            while (!reader.EndOfStream)
            {
                int i = 0;
                var str = reader.ReadLine();
                Regex name = new Regex(@"[а-яА-я]{1,20} [а-яА-я]{1,15}");
                Regex score = new Regex(@"\d \d \d");

                Match matchName = name.Match(str);
                Match matchScore = score.Match(str);

                pupils.Add(new Pupil(matchName.ToString(), SrezZnach(matchScore.ToString())));

                i++;
            }
            reader.Close();
            pupils.Sort();
            OutputPupils(pupils);
        }

        //Метод выводит 3 худших + всех остальных студентов
        public static void OutputPupils(List<Pupil> pupils)
        {
            for (int i = pupils.Count - 3; i < pupils.Count; i++)
            {
                Console.WriteLine("{0} - {1}", pupils[i].PupilName, pupils[i].PupilScore);
            }

            for(int i = 0; i < pupils.Count - 3; i++)
            {
                if(pupils[i].PupilScore == pupils[10].PupilScore || 
                   pupils[i].PupilScore == pupils[9].PupilScore  ||
                   pupils[i].PupilScore == pupils[8].PupilScore)
                   Console.WriteLine("{0} - {1}", pupils[i].PupilName, pupils[i].PupilScore);
            }
        }
        
        //Метод вычисляет средний балл
        public static int SrezZnach(string str)
        {
            var strArray = str.Split(' ');
            int summ = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                summ += int.Parse(strArray[i]);
            }
            summ /= strArray.Length;
            return summ;
        }
    }
}

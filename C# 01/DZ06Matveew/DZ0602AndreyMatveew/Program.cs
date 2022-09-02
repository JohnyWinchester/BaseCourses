using System;
using System.Collections.Generic;
using System.IO;

/* Матвеев Андрей. Задача 2.
Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
а) Сделать меню с различными функциями и представить пользователю выбор, 
для какой функции и на каком отрезке находить минимум. 
Использовать массив (или список) делегатов, в котором хранятся различные функции.
б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. 
Пусть она возвращает минимум через параметр (с использованием модификатора out).
*/
namespace DZ0602AndreyMatveew
{
    class Program
    {
        public delegate double Fun(double x);
        public static double FuncFirst(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double FuncSecond(double x)
        {
            return x * x - 50;
        }
        public static double FuncThird(double x)
        {
            return x * x  + 10;
        }

        public static void ChoseFunc()
        {
            double min;
            string chose = "";

            do
            {
                Console.WriteLine("Выберите функцию:");
                Console.WriteLine("1 - Функция X * X - 50 * x + 10:");
                Console.WriteLine("2 - Функция X * X - 50:");
                Console.WriteLine("3 - Функция X * X  + 10:");
                chose = Console.ReadLine();
                switch (chose)
                {
                    case "1":
                        Console.WriteLine("Выбрана функция X * X - 50 * x + 10");
                        SaveFunc(FuncFirst, "data.bin", -100, 100, 0.5);
                        Load("data.bin", out min);
                        break;
                    case "2":
                        Console.WriteLine("Выбрана функция X * X - 50");
                        SaveFunc(FuncSecond, "data.bin", -100, 100, 0.5);
                        Load("data.bin", out min);
                        break;
                    case "3":
                        Console.WriteLine("Выбрана функция X * X  + 10");
                        SaveFunc(FuncThird, "data.bin", -100, 100, 0.5);
                        Load("data.bin", out min);
                        break;
                    default:
                        Console.WriteLine("Номера такой функции не существует");
                        break;
                }
            } while (chose != "e");
        }
        public static void SaveFunc(Fun F,string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            while (a <= b)
            {
                bw.Write(F(a));
                a += h;
            }
            bw.Close();
            fs.Close();
        }
        public static List<double> Load(string fileName,out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            List<double> d = new List<double>();
            min = double.MaxValue;

            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d.Add(bw.ReadDouble());
                if (d[d.Count - 1] < min) min = d[d.Count - 1] - 1;
            }

            Console.WriteLine("Данные функции: ");
            foreach (var el in d)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine($"Вывод min: {min}");

            bw.Close();
            fs.Close();
            return d;
        }
        static void Main(string[] args)
        {
            ChoseFunc();
            Console.ReadKey();
        }
    }
}

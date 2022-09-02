using System;
using System.Text.RegularExpressions;

namespace DZ0501AndreyMatveew
{
    /* Матвеев Андрей. Задача 1. 
    Создать программу, которая будет проверять корректность ввода логина. 
    Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
    при этом цифра не может быть первой:
    а) без использования регулярных выражений;
    б) **с использованием регулярных выражений.
    */
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите ваш логин. Логин не должен начинаться с цифры " +
                                  "и должен включать от 2 до 10 латинских букв и цифр");
                Console.WriteLine(CreateLogin());
            }
        }

        //б) **с использованием регулярных выражений.

        public static string CreateLogin()
        {
            var login = Console.ReadLine();
            if (CorrectLogin(login))
            {
                Console.WriteLine("Вы удачно залогинились под логином:");
                return login;
            }
            Console.WriteLine("Некорректный логин");
            return null;
        }

        public static bool CorrectLogin(string login)
        {
            if (login.Length >= 2 && login.Length <= 10)
            {
                if (Regex.IsMatch(login[0].ToString(), @"\d")) return false;
                return Regex.IsMatch(login, @"[a-zA-Z]\w{1,9}");
            }
            return false;
        }

        //а) без использования регулярных выражений;

        //public static string CreateLogin()
        //{
        //    var login = Console.ReadLine();
        //    if (CorrectLogin(login))
        //    {
        //        Console.WriteLine("Вы удачно залогинились под логином:");
        //        return login;
        //    }
        //    Console.WriteLine("Некорректный логин");
        //    return null;
        //}

        //public static bool CorrectLogin(string login)
        //{
        //    if (char.IsDigit(login[0])) return false;
        //    if (login.Length >= 2 && login.Length <= 10)
        //    {
        //        for (int i = 0; i < login.Length; i++)
        //        {
        //            if (!(IsLatinLetter(login[i]) || char.IsDigit(login[i]))) return false;
        //        }
        //        return true;
        //    }
        //    return false;
        //}

        ////Проверка на латинские буквы
        //public static bool IsLatinLetter(char letter)
        //{
        //    int charNumber = letter;
        //    if ((charNumber >= 65 && charNumber <= 90) || (charNumber >= 97 && charNumber <= 122))
        //        return true;
        //    else
        //        return false;
        //}
    }
}

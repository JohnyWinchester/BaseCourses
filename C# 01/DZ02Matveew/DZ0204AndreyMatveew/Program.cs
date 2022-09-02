using System;

namespace DZ0204AndreyMatveew
{
    /* Матвеев Андрей. Задача № 4. 
    Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
    На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
    Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
    программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Authorization();
            Console.ReadKey();
        }

        public static bool Verification(string login,string password)
        {
            int i = 1;
            do
            {
                Console.WriteLine("Введите ваш логин:");
                var userLogin = Console.ReadLine();

                Console.WriteLine("Введите ваш пароль:");
                var userPass = Console.ReadLine();

                if (userLogin == login && userPass == password) return true;
                if (userLogin != login) Console.WriteLine("Вы ввели неправильный логин");
                if (userPass != password) Console.WriteLine("Вы ввели неправильный пароль");

                i++;
            } while (i <= 3);

            return false;
        }

        public static void Authorization()
        {
            if (Verification("root", "GeekBrains")) Console.WriteLine("\nПоздравляшки))) Вы успешно вошли в программу");
            else Console.WriteLine("\nВы не прошли авторизацию!!!!!!");
        }
    }
}

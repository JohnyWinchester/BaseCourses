using System;

namespace DZ0404AndreyMatveew
{
    /*Матвеев Андрей. Задача 4
    Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
    Создайте структуру Account, содержащую Login и Password.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Authorization();
            Console.ReadKey();
        }

        public static bool Verification(string login, string password)
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
            //Я не понял смысл задачи и чё тут и куда вводить и сделал так.....
            Account acc = new Account(@"E:\GeekBrains\C# 01\DZ04Matveew\DZ0404AndreyMatveew\AccFile.txt");
            if (Verification(acc.Login, acc.Password)) Console.WriteLine("\nПоздравляшки))) Вы успешно вошли в программу");
            else Console.WriteLine("\nВы не прошли авторизацию!!!!!!");
        }
    }
}

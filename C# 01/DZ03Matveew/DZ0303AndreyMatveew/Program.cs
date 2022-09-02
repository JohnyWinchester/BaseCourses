using System;

namespace DZ0303AndreyMatveew
{
    /* Матвеев Андрей. Задача № 3. 
    *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
    * Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
    * Написать программу, демонстрирующую все разработанные элементы класса.
    * Добавить свойства типа int для доступа к числителю и знаменателю;
    * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
    *** Добавить упрощение дробей.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Fractions fraction1 = new Fractions(4, 2);
            Fractions fraction2 = new Fractions(1, 3);

            fraction1 = fraction1.Addition(fraction2);
            Console.WriteLine($"Сложение дробей: {fraction1}");
            //Console.WriteLine($"Вычитание дробей: {fraction1.Substraction(fraction2)}");
            //Console.WriteLine($"Умножение дробей: {fraction1.Multi(fraction2)}");
            //Console.WriteLine($"Деление дробей: {fraction1.Division(fraction2)}");


            Console.WriteLine("Свойство типа double: {0:F2}", fraction1.DecimalFraction);

            Console.ReadKey();
        }
    }
}

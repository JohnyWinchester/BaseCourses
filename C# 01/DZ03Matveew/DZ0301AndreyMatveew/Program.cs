using System;

namespace DZ0301AndreyMatveew
{
    class Program
    {
        /* Матвеев Андрей. Задача № 1. 
        а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
        б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
        в) Добавить диалог с использованием switch демонстрирующий работу класса.
        */
        static void Main(string[] args)
        {
            //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
            //Продемонстрировать работу структуры.
            Complex number = new Complex();
            number.im = 3;
            number.re = 3;
            Complex numberSecond = new Complex();
            numberSecond.im = 1;
            numberSecond.re = 1;
            //Вычитание структуры
            Console.WriteLine($"Вычитание: {number.Minus(numberSecond)}");
            //Сложение структуры
            Console.WriteLine($"Сложение: {number.Plus(numberSecond)}");
            //Умножение структуры
            Console.WriteLine($"Умножение: {number.Multi(numberSecond)}");

            //Проверка работы класса 
            ComplexClass complexNum1 = new ComplexClass(4, 2);
            ComplexClass complexNum2 = new ComplexClass(3, 1);

           while(true)
           {
                Console.WriteLine("Введите: 1 для Сложения 2 для Вычитания и 3 для Умножения");
                int chooseAction = Int32.Parse(Console.ReadLine());

                switch (chooseAction)
                {
                    case 1:
                        Console.WriteLine($"Сложение: {complexNum1.Plus(complexNum2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Вычитание: {complexNum1.Minus(complexNum2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Умножение: {complexNum1.Multi(complexNum2)}");
                        break;
                    default:
                        Console.WriteLine("Нет такой операции");
                        break;
                }
           }
        }

        struct Complex
        {
            public double im;
            public double re;
            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }

            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            public override string ToString()
            {
                return re + "+" + im + "i";
            }
        }

    }
}

using System;
using MyArrayMatrix;

namespace DZ0405AndreyMatveew
{
    /*Матвеев Андрей. Задача 5
    *а) Реализовать библиотеку с классом для работы с двумерным массивом. 
    * Реализовать конструктор, заполняющий массив случайными числами. 
    * Создать методы, которые возвращают сумму всех элементов массива, 
    * сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, 
    * свойство, возвращающее максимальный элемент массива, метод,
    * возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
    **б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    **в) Обработать возможные исключительные ситуации при работе с файлами.
    */
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов обычного конструктора
            MyMatrix matrix = new MyMatrix(3, 3, 1, 10);
            matrix.OutputArray();

            //Вызов конструктора с файлом
            //MyMatrix matrixFile = new MyMatrix(@"E:\GeekBrains\C# 01\DZ04Matveew\DZ0405AndreyMatveew\Matrix.txt");
            //matrixFile.OutputArray();

            Console.WriteLine($"\nМинимальный элемент: {matrix.GetMinElement}");
            Console.WriteLine($"Максимальный элемент: {matrix.GetMaxElement}");
            Console.WriteLine($"Индекс максимального элемента: {matrix.GetMaxIndex}");

            Console.WriteLine($"\nСумма всех элементов массива: {matrix.Sum()}");
            Console.WriteLine($"\nСумма всех элементов массива больше n: {matrix.SumLarger(2)}");

            Console.ReadKey();
        }
    }
}

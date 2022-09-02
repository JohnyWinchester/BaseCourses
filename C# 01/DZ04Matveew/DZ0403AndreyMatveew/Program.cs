using System;
using MyArray;

namespace DZ0403AndreyMatveew
{
    /*Матвеев Андрей. Задача 3
      а) Дописать класс для работы с одномерным массивом. 
      Реализовать конструктор, создающий массив определенного размера
      и заполняющий массив числами от начального значения с заданным шагом.
      Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse,
      возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
      метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount,
      возвращающее количество максимальных элементов. 
      б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Заполняем массив");
            MyArrayClass arr = new MyArrayClass(3, 0, 3);
            for (int i = 0; i < arr.Lenght; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Вызываем свойство Sum:");
            Console.WriteLine(arr.Sum);

            Console.WriteLine("Вызываем метод Inverse:");
            var inverseArray = arr.Inverse();
            for (int i = 0; i < inverseArray.Length; i++)
            {
                Console.WriteLine(inverseArray[i]);
            }

            Console.WriteLine("Вызываем метод Multi:");
            var multiArray = arr.Multi(2);
            for (int i = 0; i < multiArray.Length; i++)
            {
                Console.WriteLine(multiArray[i]);
            }

            Console.ReadKey();
        }
    }
}

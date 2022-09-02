using System;

namespace MyArray
{
     // б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
    public class MyArrayClass
    {
        int[] a;
        public int this[int i]
        {
            get { return a[i]; }
            set { a[i] = value; }
        }

        public int Lenght
        {
            get { return a.Length; }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }

        }

        public MyArrayClass(int lenght, int firstNumber, int step)
        {
            a = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                a[i] = firstNumber;
                firstNumber += step;
            }
        }

        public int[] Inverse()
        {
            int[] inverseArray = new int[a.Length];
            for (int i = 0; i < inverseArray.Length; i++)
            {
                inverseArray[i] = -a[i];
            }
            return inverseArray;
        }

        public int[] Multi(int multiNumber)
        {
            int[] multiArray = new int[a.Length];
            for (int i = 0; i < multiArray.Length; i++)
            {
                multiArray[i] = multiNumber * a[i];
            }
            return multiArray;
        }
    }
}

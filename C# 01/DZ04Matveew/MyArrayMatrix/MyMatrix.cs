using System;
using System.IO;

namespace MyArrayMatrix
{
    //*а) Реализовать библиотеку с классом для работы с двумерным массивом. 
    //* Реализовать конструктор, заполняющий массив случайными числами. 
    //* Создать методы, которые возвращают сумму всех элементов массива, 
    //* сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, 
    //* свойство, возвращающее максимальный элемент массива, метод,
    //* возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
    public class MyMatrix
    {
        int[,] a;
        public int this[int i, int j]
        {
            get { return a[i, j]; }
            set { a[i, j] = value; }
        }

        //Cвойство возвращающее минимальный элемент массива
        public int GetMinElement
        {
            get 
            {
                int minNumber = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] < minNumber) minNumber = a[i, j];
                    }
                }
                return minNumber;
            }
        }

        //Cвойство возвращающее максимальный элемент массива
        public int GetMaxElement
        {
            get
            {
                int maxNumber = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > maxNumber) maxNumber = a[i, j];
                    }
                }
                return maxNumber;
            }
        }

        //Cвойство возвращающее индекс максимального элемента массива. Не понял как сделать с помощью ref и out.
        public (int,int) GetMaxIndex
        {
            get
            {
                int maxNumber = a[0, 0];
                int maxIndexLine = 0;
                int maxIndexColumn = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > maxNumber) 
                        {
                            maxNumber = a[i, j];
                            maxIndexLine = i;
                            maxIndexColumn = j;
                        }
                    }
                }
                return (maxIndexLine,maxIndexColumn);
            }
        }

        public MyMatrix(int line, int column, int minNumber, int maxNumber)
        {
            a = new int[line, column];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Random rnd = new Random();
                    a[i, j] = rnd.Next(minNumber, maxNumber);
                }
            }
        }

        public MyMatrix(string path)
        {
            try
            {
                StreamReader readFile = new StreamReader(path);
                int line = Int32.Parse(readFile.ReadLine());
                int column = Int32.Parse(readFile.ReadLine());

                a = new int[line, column];
                for(int i = 0;i < a.GetLength(0); i++)
                {
                    for(int j = 0; j < a.GetLength(1); j++)
                    {
                        if (!readFile.EndOfStream) 
                            a[i,j] = Int32.Parse(readFile.ReadLine());
                    }
                }
                readFile.Close();
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }

        public void OutputArray()
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j]);
                }
            }
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
            return sum;
        }

        // Метод возвращает сумму всех элементов массива больше заданного
        public int SumLarger(int largerNumber)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(a[i, j] > largerNumber) sum += a[i, j];
                }
            }
            return sum;
        }
    }
}

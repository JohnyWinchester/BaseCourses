using System;

namespace AndreyMatveew02Algorithm2
{
    //Матвеев Андрей.Алгоритмы и структуры данных.Базовый курс 02.
    //Реализовать функцию возведения числа a в степень b:
    //b.Рекурсивно.
    //c. *Рекурсивно, используя свойство чётности степени
    class Program
    {
        static void Main(string[] args)
        {
            //b.Рекурсивно.
            DegreeNumber(9,9,5,1);

            //c. *Рекурсивно, используя свойство чётности степени
            ParityDegreeNumber(-9, -9, 5, 1);

            Console.ReadKey();
        }

        //b.Рекурсивно.
        public static void DegreeNumber(int num,int numAfterDegree,int degree,int degreeCount)
        {
            if(degreeCount == degree)
            {
                Console.WriteLine(numAfterDegree);
                return;
            }

            DegreeNumber(num, numAfterDegree * num,degree,++degreeCount);
        }

        //c. *Рекурсивно, используя свойство чётности степени
        public static void ParityDegreeNumber(int num, int numAfterDegree, int degree, int degreeCount)
        {
            if (degreeCount == degree)
            {
                Console.WriteLine(numAfterDegree);
                return;
            }

            if(degree % 2 == 0)
                ParityDegreeNumber(num, numAfterDegree * num, degree, ++degreeCount);
            else
                ParityDegreeNumber(-num, -numAfterDegree * -num, degree, ++degreeCount);
        }
    }
}

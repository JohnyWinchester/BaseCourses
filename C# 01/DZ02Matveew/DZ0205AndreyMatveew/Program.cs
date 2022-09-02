using System;

namespace DZ0205AndreyMatveew
{
    /* Матвеев Андрей. Задача № 5. 
    а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
    нужно ли человеку похудеть, набрать вес или всё в норме.
    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    */
    class Program
    {
        static void Main(string[] args)
        {
            MassIndex();
            Console.ReadKey();
        }

        public static void MassIndex()
        {
            Console.WriteLine("Введите ваш вес:");
            double weight = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост в метрах:");
            double height = Double.Parse(Console.ReadLine());

            double massIndex = weight / (height * height);

            Console.WriteLine("Ваш индекс массы тела: {0:F2}", massIndex);
            Slimming(massIndex, weight, height);
        }

        public static void Slimming(double massIndex,double weight,double height)
        {
            //Минимальный и максимальный индекс массы тела
            double lowerThreshold = 18.5;
            double upperThreshold = 24.99;

            if(massIndex < lowerThreshold)
            {
                int i = 1;
                do
                {
                    massIndex = (weight + i) / (height * height);
                    i++;
                } while (massIndex < lowerThreshold);
                Console.WriteLine($"Вам нужно потолстеть на: {i} кг ");
            }

            else if(massIndex > upperThreshold)
            {
                int i = 1;
                do
                {
                    massIndex = (weight - i) / (height * height);
                    i++;
                } while (massIndex > lowerThreshold);
                Console.WriteLine($"Вам нужно похудеть на: {i} кг ");
            }

            else
                Console.WriteLine("У вас всё хорошо))))");
        }
    }
}

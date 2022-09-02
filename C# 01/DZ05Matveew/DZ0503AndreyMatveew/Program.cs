using System;

namespace DZ0503AndreyMatveew
{
    class Program
    {
        /* Матвеев Андрей. Задача 3. 
        *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        Например:
        badc являются перестановкой abcd.
        */
        static void Main(string[] args)
        {
            Console.WriteLine(Reversion("abcd", "dcba"));
            Console.ReadKey();
        }

        public static bool Reversion(string original, string reverse)
        {
            int originalLenght = original.Length;
            int reverseLenght = reverse.Length;

            for (int j = 0; j < reverse.Length; j++)
                if (!(CheckLetters(reverse[j], original))) reverseLenght--;

            if (originalLenght != reverseLenght) return false;
            return true;
        }
        
        //Метод возвращает true если данная буква есть в слове
        public static bool CheckLetters(char letter, string original)
        {
            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] == letter) return true;
            }
            return false;
        }
    }
}

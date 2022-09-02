using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DZ0401AndreyMatveew
{
    static class StaticClass
    {
        public static int[] CountArray(string path)
        {
            try
            {
                StreamReader readFile = new StreamReader(path);
                int[] numArray = new int[20];

                for (int i = 0; i < numArray.Length; i++)
                {
                    numArray[i] = Int32.Parse(readFile.ReadLine());
                }

                readFile.Close();
                return numArray;
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
                return new int[1];
            }
        }

        //Решение первой задачи
        public static int MatchNumbers(int[] array)
        {
            int matches = 0;
            for(int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 && array[i + 1] % 3 == 0) matches++;
            }
            return matches;
        }
    }
}

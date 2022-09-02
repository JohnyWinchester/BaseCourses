using System;
using System.Collections.Generic;
using System.Text;

namespace DZ0502AndreyMatveew
{
    static class Message
    {
        //а) Вывести только те слова сообщения,  которые содержат не более n букв.
        public static void AmountLetters(string str, int amountLet)
        {
            string[] strArray = str.Split(' ');
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length <= amountLet) Console.WriteLine(strArray[i]);
            }
        }

        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        public static string DeleteLetters(string str, char symbol)
        {
            string[] strArray = str.Split(' ');
            List<string> line = new List<string>();
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i][strArray[i].Length - 1] != symbol) line.Add(strArray[i]);
            }
            return String.Join(' ', line);
        }

        //в) Найти самое длинное слово сообщения.
        public static string MostLongLetter(string str)
        {
            string[] strArray = str.Split(' ');
            str = strArray[0];
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length > str.Length) str = strArray[i];
            }
            return str;
        }

        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        public static StringBuilder MostLongLetters(string str)
        {
            string[] strArray = str.Split(' ');
            List<string> line = new List<string>();
            line.Add(MostLongLetter(str));

            for (int i = 0; i < strArray.Length; i++)
            {
                int lenght = 2;
                for (int j = 0; j < strArray[i].Length; j++)
                {
                    if (strArray[i].Length == line[0].Length || strArray[i].Length == line[0].Length - lenght)
                    {
                        if (line[0] == strArray[i]) continue;
                        line.Add(strArray[i]);
                    }
                    lenght--;
                }
            }

            StringBuilder longLetters = new StringBuilder(String.Join(' ', line));
            return longLetters;
        }

        //д)***Создать метод, который производит частотный анализ текста.
        public static Dictionary<string, int> FrequencyAnalysis(string str)
        {
            string[] strArray = str.Split(' ');
            Dictionary<string, int> textAnalysis = new Dictionary<string, int>();

            for (int i = 0;i < strArray.Length;i++)
            {
                if(textAnalysis.ContainsKey(strArray[i]))
                {
                    textAnalysis[strArray[i]]++;
                    continue;
                }
                textAnalysis.Add(strArray[i], 1);
            }
            return textAnalysis;
        }
    }
}

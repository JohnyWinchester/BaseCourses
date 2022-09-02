using System;

/* Матвеев Андрей. Задача № 1, № 2 и № 5. 
1)Написать программу «Анкета».
Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).

2)Ввести вес и рост человека. 
Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

5)Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.*/

namespace DZ01AndreyMatveew
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаётся экземпляр класса Questionary
            Questionary questionary = new Questionary();
            // Вызывается метод вывода данных анкеты
            questionary.PrintQuestionary();
            //Вывожу индекс массы тела
            questionary.BodyIndex();

            Console.ReadKey();
        }
    }
}

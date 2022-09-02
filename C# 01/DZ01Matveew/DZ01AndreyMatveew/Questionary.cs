using System;
using System.Collections.Generic;
using System.Text;

namespace DZ01AndreyMatveew
{
    //Класс отвечающий за данные анкеты
    class Questionary
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public double Height { get; set; }
        public string City { get; set; }

        //Инициализирую поля класса Questionary
        public Questionary()
        {
            Console.WriteLine("Заполните анкету. Вам по очереди будут заданы вопросы.");
            Console.WriteLine("Ваше имя: ");
            this.Name = Console.ReadLine();

            Console.WriteLine("Ваша фамилия: ");
            this.SurName = Console.ReadLine(); 

            Console.WriteLine("Ваш возраст: ");
            this.Age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ваш вес: ");
            this.Weight = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ваш рост в метрах: ");
            this.Height = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ваш город: ");
            this.City = Console.ReadLine();
        }
        //Создаю метод вывода данных анкеты.
        public void PrintQuestionary()
        {
            string spaces = new String(' ', 40);
            Console.WriteLine("{0}" + this.Name + " ваша анкета:\n", spaces);
            Console.WriteLine(spaces + $"Фамилия Имя: {this.Name} {this.SurName}\n");
            Console.WriteLine(spaces + $"Возраст: {this.Age} годиков\n");
            Console.WriteLine(spaces + $"Вес в киллограмах: {this.Weight} кг\n");
            Console.WriteLine(spaces + $"Рост в метрах: {this.Height} м\n");
            Console.WriteLine(spaces + $"Город проживания: {this.City}\n");
        }
        // Метод расчёта индекса массы тела
        public void BodyIndex()
        {
            Console.WriteLine("Ваш индекс массы тела: {0:F2}", this.Weight / (this.Height * this.Height));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ0802AndreyMatveew
{
    static class Guess
    {
        private static int tryCount = 4;
        private static int guessNumber = new Random().Next(1, 100);
        private static int userNumber = 0;
        //Свойство с доступом к полю с количеством попыток
        public static int TryCount 
        {
            get 
            {
                return tryCount;
            } 
            set
            {
                tryCount = value;
            } 
        }
        //Свойство с доступом к полю с числом которое необходимо угадать
        public static int GuessNumber
        {
            get
            {
                return guessNumber;
            }
        }
        //Свойство с доступом к полю которое необходимо ввести игроку 
        public static int UserNumber
        {
            get
            {
                return userNumber;
            }

            set
            {
                if (value < 0 || value > 100) throw new ArgumentException();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DZ0802AndreyMatveew
{
    // Класс для вопроса    
    [Serializable]
    public class Question
    {
        private string text;       // Текст вопроса
        private bool trueFalse;    // Правда или нет

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if (value.GetType() == typeof(string)) text = value;
            }
        }
        public bool TrueFalse
        {
            get
            { 
                return trueFalse;
            }
            set
            {
                if (value.GetType() == typeof(bool)) trueFalse = value;
            }
        }

        public Question()
        {
        }
        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }
    }
}

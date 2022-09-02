using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DZ0404AndreyMatveew
{
    struct Account
    {
        public string Login { get; }
        public string Password { get; }

        public Account(string path) : this()
        {
            try
            {
                StreamReader readFile = new StreamReader(path);
                Login = readFile.ReadLine();
                Password = readFile.ReadLine();
                readFile.Close();
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так");
            }
        }
    }
}

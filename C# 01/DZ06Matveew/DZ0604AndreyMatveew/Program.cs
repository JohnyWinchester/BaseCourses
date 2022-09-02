using System;
using System.Diagnostics;
using System.IO;

/* Матвеев Андрей. Задача 4.
**Считайте файл различными способами. Смотрите “Пример записи файла различными способами”.
* Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), 
* строку для StreamReader и массив int для BinaryReader.
*/
namespace DZ0604AndreyMatveew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Считываю файл с помощью FileStream: ");
            FileStreamSample();
            Console.WriteLine("\nСчитываю файл с помощью BufferedStream: ");
            BufferedStreamSample();
            Console.WriteLine("\nСчитываю файл с помощью BinaryReader : ");
            BinaryStreamSample();
            Console.WriteLine("\nСчитываю файл с помощью StreamReader: ");
            StreamReaderSample();
            Console.ReadKey();
        }

        //Метод считывает файл с помощью FileStream и возвращает массив byte 
        static byte[] FileStreamSample()
        {
            FileStream fs = new FileStream(@"E:\GeekBrains\C# 01\DZ06Matveew\DZ0604AndreyMatveew\bigdata.bin", 
                                           FileMode.Open, FileAccess.Read);
            byte[] fileContent = new byte[fs.Length];

            for (int i = 0;i < fs.Length;i++)
            {
                fileContent[i] = (byte)fs.ReadByte();
            }
            fs.Close();

            foreach(var el in fileContent)
            {
                Console.WriteLine(el);
            }

            return fileContent;
        }

        //Метод считывает файл с помощью BufferedStream и возвращает массив byte 
        static byte[] BufferedStreamSample()
        {
            FileStream fs = new FileStream(@"E:\GeekBrains\C# 01\DZ06Matveew\DZ0604AndreyMatveew\bigdata.bin",
                                           FileMode.Open, FileAccess.Read);
            BufferedStream buffered = new BufferedStream(fs);
            byte[] fileContent = new byte[buffered.Length];

            for (int i = 0; i < buffered.Length; i++)
            {
                fileContent[i] = (byte)buffered.ReadByte();
            }
            fs.Close();
            buffered.Close();

            foreach (var el in fileContent)
            {
                Console.WriteLine(el);
            }
            return fileContent;
        }

        //Метод считывает файл с помощью BinaryReader и возвращает массив byte 
        static int[] BinaryStreamSample()
        {
            FileStream fs = new FileStream(@"E:\GeekBrains\C# 01\DZ06Matveew\DZ0604AndreyMatveew\bigdata.bin",
                                           FileMode.Open, FileAccess.Read);
            BinaryReader binary = new BinaryReader(fs);
            int[] fileContent = new int[fs.Length];

            for (int i = 0; i < fs.Length; i++)
            {
                fileContent[i] = binary.ReadByte();
            }
            fs.Close();
            binary.Close();

            foreach (var el in fileContent)
            {
                Console.WriteLine(el);
            }
            return fileContent;
        }

        //Метод считывает файл с помощью StreamReader и возвращает массив byte 
        static string StreamReaderSample()
        {
            FileStream fs = new FileStream(@"E:\GeekBrains\C# 01\DZ06Matveew\DZ0604AndreyMatveew\bigdata.bin",
                                           FileMode.Open, FileAccess.Read);
            StreamReader file = new StreamReader(fs);
            string fileContent = "";

            for (int i = 0; i < fs.Length; i++)
            {
                fileContent += file.Read().ToString();
                fileContent += " ";
            }
            fs.Close();
            file.Close();

            Console.WriteLine(fileContent);
            return fileContent;
        }
    }
}

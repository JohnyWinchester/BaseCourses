using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace AndreyMatveew08Algorithm
{
    public class ExcelStatisticsFile
    {
        private ExcelPackage book;
        private ExcelWorksheet statisticsSheet;
        private int[] hundredArr;
        private int[] tenThousandArr;
        private int[] millionArr;
        public ExcelPackage Book
        {
            get { return book; }

            private set { book = value; }
        }
        public ExcelWorksheet StatisticsSheet
        {
            get { return statisticsSheet; }

            private set { statisticsSheet = value; }
        }
        public int[] HundredArr
        {
            get { return hundredArr; }

            private set { hundredArr = value; }
        }
        public int[] TenThousandArr
        {
            get { return tenThousandArr; }

            private set { tenThousandArr = value; }
        }
        public int[] MillionArr
        {
            get { return millionArr; }

            private set { millionArr = value; }
        }
        public ExcelStatisticsFile(int[] hundredArr, int[] tenThousandArr, int[] millionArr)
        {
            HundredArr = hundredArr;
            TenThousandArr = tenThousandArr;
            MillionArr = millionArr;

            Book = new ExcelPackage();
            StatisticsSheet = Book.Workbook.Worksheets.Add("Sorting Statistics");

            GenerateFile();
        }
        private void GenerateFile()
        {
            ExcelHeaderFormating();
            ExcelFormating();
            SortingsTests();

            File.WriteAllBytes("SortingStatistics.xlsx", Book.GetAsByteArray()); //....AndreyMatveew08Algorithm\AndreyMatveew08Algorithm\bin\Debug\net5.0
            Console.WriteLine("File done");
        }
        private void ExcelHeaderFormating()
        {
            StatisticsSheet.Cells["A1"].Value = "ФИО";

            StatisticsSheet.Cells[1, 1, 4, 2].Style.Border.BorderAround(ExcelBorderStyle.Thick);
            StatisticsSheet.Cells[1, 1, 4, 2].Style.Border.Top.Style = ExcelBorderStyle.Thick;
            StatisticsSheet.Cells[1, 1, 4, 2].Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
            StatisticsSheet.Cells[1, 1, 4, 2].Style.Border.Right.Style = ExcelBorderStyle.Thick;
            StatisticsSheet.Cells[1, 1, 4, 2].Style.Border.Left.Style = ExcelBorderStyle.Thick;
            StatisticsSheet.Cells[1, 1, 4, 1].Style.Font.Bold = true;

            StatisticsSheet.Cells["A2"].Value = "Процессор";
            StatisticsSheet.Cells["A2"].Style.Font.Bold = true;
            StatisticsSheet.Column(1).Width = 25;

            StatisticsSheet.Cells["A3"].Value = "ОС";
            StatisticsSheet.Cells["A3"].Style.Font.Bold = true;

            StatisticsSheet.Cells["A4"].Value = "Среда Программирования";
            StatisticsSheet.Cells["A4"].Style.Font.Bold = true;

            StatisticsSheet.Cells["B1"].Value = "Матвеев Андрей Олегович";
            StatisticsSheet.Column(2).Width = 24;
        }
        private void ExcelFormating()
        {
            StatisticsSheet.Cells[6, 1, 12, 4].Style.Border.BorderAround(ExcelBorderStyle.Thick);
            StatisticsSheet.Cells[6, 1, 12, 4].Style.Border.Top.Style = ExcelBorderStyle.Thick;
            StatisticsSheet.Cells[6, 1, 12, 4].Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
            StatisticsSheet.Cells[6, 1, 12, 4].Style.Border.Right.Style = ExcelBorderStyle.Thick;
            StatisticsSheet.Cells[6, 1, 12, 4].Style.Border.Left.Style = ExcelBorderStyle.Thick;
            StatisticsSheet.Cells[6, 1, 12, 1].Style.Font.Bold = true;

            StatisticsSheet.Cells["B2"].Value = "Intel Core i7-4770";
            StatisticsSheet.Cells["B3"].Value = "Windows 10";
            StatisticsSheet.Cells["B4"].Value = "Visual Studio";

            StatisticsSheet.Cells["A6"].Value = "Название Сортировки";
            StatisticsSheet.Cells["A6"].Style.Font.Bold = true;

            StatisticsSheet.Cells["B6"].Value = "Время на 100 элементов";
            StatisticsSheet.Cells["B6"].Style.Font.Bold = true;

            StatisticsSheet.Cells["C6"].Value = "Время на 10000 элементов";
            StatisticsSheet.Cells["C6"].Style.Font.Bold = true;
            StatisticsSheet.Column(3).Width = 27;

            StatisticsSheet.Cells["D6"].Value = "Время на 1000000 элементов";
            StatisticsSheet.Cells["D6"].Style.Font.Bold = true;
            StatisticsSheet.Column(4).Width = 27;

            StatisticsSheet.Cells["A7"].Value = "Quick Sort";
            StatisticsSheet.Cells["A8"].Value = "Shell Sort";
            StatisticsSheet.Cells["A9"].Value = "Merge Sort";
            StatisticsSheet.Cells["A10"].Value = "Heap Sort";
            StatisticsSheet.Cells["A11"].Value = "Bubble Sort";
            StatisticsSheet.Cells["A12"].Value = "Shake Sort";
        }
        private void SortingsTests()
        {
            Sortings.Sorts sorts = new(hundredArr, tenThousandArr, millionArr);
            var sortRes = sorts.SortingsResults;

            StatisticsSheet.Cells[7, 2, 12, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
            for(int i = 7;i < 13;i++)
            {
                StatisticsSheet.Cells[$"B{i}"].Value = $"{sortRes[i - 7][0]} мс";
                StatisticsSheet.Cells[$"C{i}"].Value = $"{sortRes[i - 7][1]} мс";
                StatisticsSheet.Cells[$"D{i}"].Value = $"{sortRes[i - 7][2]} мс";
            }
            StatisticsSheet.Cells[$"D11"].Value = $"Очень долго";
        }
    }
}

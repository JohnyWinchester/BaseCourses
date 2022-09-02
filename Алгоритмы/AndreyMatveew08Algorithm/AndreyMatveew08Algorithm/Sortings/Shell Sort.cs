using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyMatveew08Algorithm.Sortings
{
    public class Shell_Sort
    {
        public static long[] Shell(int[] hundredArr, int[] tenThousandArr, int[] millionArr)
        {
            long[] times = new long[3];
            times[0] = TimeCalculating(hundredArr);
            times[1] = TimeCalculating(tenThousandArr);
            times[2] = TimeCalculating(millionArr);

            return times;
        }
        private static long TimeCalculating(int[] arr)
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            var sortArr = ShellSort(arr);
            stopwatch.Stop();
            return stopwatch.Elapsed.Milliseconds;
        }
        static void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t;
        }
        static int[] ShellSort(int[] array)
        {
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }
                d = d / 2;
            }
            return array;
        }
    }
}

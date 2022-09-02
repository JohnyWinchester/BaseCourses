using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyMatveew08Algorithm.Sortings
{
    public static class Quick_Sort
    {
        public static long[] Quick(int[] hundredArr, int[] tenThousandArr, int[] millionArr)
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
            var sortArray = QuickSort(arr, 0, arr.Length - 1);
            stopwatch.Stop();
            return stopwatch.Elapsed.Milliseconds;
        }
        private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if(minIndex >= maxIndex)
            {
                return array;
            }

            var pivot = PivotIndex(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivot - 1);
            QuickSort(array, pivot + 1, maxIndex);
            return array;
        }
        private static int PivotIndex(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for(int i = minIndex; i < maxIndex;i++)
            {
                if(array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot],ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        private static void Swap(ref int pivot, ref int index)
        {
            var t = pivot;
            pivot = index;
            index = t;
        }
    }
}

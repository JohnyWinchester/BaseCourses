using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyMatveew08Algorithm.Sortings
{
    public class Heap_Sort
    {
        public static long[] Heap(int[] hundredArr, int[] tenThousandArr, int[] millionArr)
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
            HeapSort(arr);
            stopwatch.Stop();
            return stopwatch.Elapsed.Milliseconds;
        }
        static void HeapSort(int[] array)
        {
            var length = array.Length;
            for (int i = length / 2 - 1; i >= 0; i--)
            {
                Heapify(array, length, i);
            }
            for (int i = length - 1; i >= 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                Heapify(array, i, 0);
            }
        }
        static void Heapify(int[] array, int length, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < length && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < length && array[right] > array[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                Heapify(array, length, largest);
            }
        }
    }
}

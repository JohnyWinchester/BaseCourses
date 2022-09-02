﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyMatveew08Algorithm.Sortings
{
    public class Merge_Sort
    {
        public static long[] Merge(int[] hundredArr, int[] tenThousandArr, int[] millionArr)
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
            var sortArr = MergeSort(arr, 0, arr.Length - 1);
            stopwatch.Stop();
            return stopwatch.Elapsed.Milliseconds;
        }
        static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
        static int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }
    }
}

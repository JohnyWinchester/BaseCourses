using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyMatveew08Algorithm.Sortings
{
    public class Sorts
    {
        private int[] hundredArr;
        private int[] tenThousandArr;
        private int[] millionArr;
        private long[][] sortingsResults;
        public long[][] SortingsResults
        {
            get { return sortingsResults; }

            private set { sortingsResults = value; }
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
        public Sorts(int[] hundredArr, int[] tenThousandArr, int[] millionArr)
        {
            HundredArr = hundredArr;
            TenThousandArr = tenThousandArr;
            MillionArr = millionArr;
            SortingsResults = SortsCalculation();
        }
        private long[][] SortsCalculation()
        {
            long[][] results = new long[6][];
            results[0] = Quick_Sort.Quick(hundredArr, tenThousandArr, millionArr);
            results[1] = Shell_Sort.Shell(hundredArr, tenThousandArr, millionArr);
            results[2] = Merge_Sort.Merge(hundredArr, tenThousandArr, millionArr);
            results[3] = Heap_Sort.Heap(hundredArr, tenThousandArr, millionArr);
            results[4] = Bubble_Sort.Bubble(hundredArr, tenThousandArr, millionArr);
            results[5] = Shake_Sort.Shake(hundredArr, tenThousandArr, millionArr);

            return results;
        }
    }
}

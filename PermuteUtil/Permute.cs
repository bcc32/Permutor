using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PermuteUtil
{
    public class Permute
    {
        public static bool NextPermutation<Datum>(ref List<Datum> data) where Datum : IComparable
        {
            return NextPermutation(ref data, Comparer<Datum>.Default);
        }

        public static bool NextPermutation<Datum>(ref List<Datum> data, IComparer<Datum> comparer)
        {
            for (int i = data.Count - 1; i > 0; i--)
            {
                if (comparer.Compare(data[i - 1], data[i]) < 0)
                {
                    int j;
                    int smallest = i;
                    for (j = i + 1; j < data.Count; j++)
                        if (comparer.Compare(data[j], data[i - 1]) > 0
                                && comparer.Compare(data[j], data[smallest]) < 0)
                            smallest = j;
                    Datum temp = data[i - 1];
                    data[i - 1] = data[smallest];
                    data[smallest] = temp;

                    data.Sort(i, data.Count - i, comparer);
                    return true;
                }
            }

            return false;
        }

        public static bool PreviousPermutation<Datum>(ref List<Datum> data) where Datum : IComparable
        {
            return PreviousPermutation(ref data, Comparer<Datum>.Default);
        }

        public static bool PreviousPermutation<Datum>(ref List<Datum> data, IComparer<Datum> comparer)
        {
            return NextPermutation(ref data, new ReverseComparer<Datum>());
        }

        class ReverseComparer<Datum> : Comparer<Datum>
        {
            override public int Compare(Datum x, Datum y)
            {
                return Comparer<Datum>.Default.Compare(y, x);
            }
        }
    }
}

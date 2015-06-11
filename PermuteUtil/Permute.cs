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
            return NextPermutation(ref data, new DefaultComparer<Datum>());
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
            return PreviousPermutation(ref data, new DefaultComparer<Datum>());
        }

        public static bool PreviousPermutation<Datum>(ref List<Datum> data, IComparer<Datum> comparer)
        {
            return NextPermutation(ref data, makeReverseComparer(comparer));
        }

        private static IComparer<Datum> makeReverseComparer<Datum>(IComparer<Datum> comparer)
        {
            return new ReverseAnotherComparer<Datum>(comparer);
        }

        class DefaultComparer<Datum> : IComparer<Datum> where Datum : IComparable
        {
            int IComparer<Datum>.Compare(Datum x, Datum y)
            {
                return x.CompareTo(y);
            }
        }

        class ReverseComparer<Datum> : IComparer<Datum> where Datum : IComparable
        {
            int IComparer<Datum>.Compare(Datum x, Datum y)
            {
                return y.CompareTo(x);
            }
        }

        class ReverseAnotherComparer<Datum> : IComparer<Datum>
        {
            private IComparer<Datum> comparer;

            public ReverseAnotherComparer(IComparer<Datum> comparer)
            {
                this.comparer = comparer;
            }

            int IComparer<Datum>.Compare(Datum x, Datum y)
            {
                return comparer.Compare(y, x);
            }
        }
    }
}

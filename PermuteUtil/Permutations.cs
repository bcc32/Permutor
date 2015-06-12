using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PermuteUtil
{
    public class Permutations<Datum> : IEnumerable<List<Datum>> where Datum : IComparable
    {
        private List<Datum> data;

        public Permutations(List<Datum> data)
        {
            this.data = data;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<List<Datum>> GetEnumerator()
        {
            do
            {
                yield return data;
            } while (Permute.NextPermutation(ref data));
        }
    }

    public class ThePermutations
    {
        public static Permutations<Datum> of<Datum>(List<Datum> data) where Datum : IComparable
        {
            return new Permutations<Datum>(data);
        }
    }
}

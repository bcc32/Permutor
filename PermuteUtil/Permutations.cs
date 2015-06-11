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
            return new PermutationEnumerator(data);
        }

        IEnumerator<List<Datum>> IEnumerable<List<Datum>>.GetEnumerator()
        {
            return new PermutationEnumerator(data);
        }

        class PermutationEnumerator : IEnumerator<List<Datum>>
        {
            private List<Datum> _orig;
            private List<Datum> data;
            bool started = false;

            public PermutationEnumerator(List<Datum> data)
            {
                this._orig = data;
                this.data = new List<Datum>(_orig);
            }

            object IEnumerator.Current
            {
                get
                {
                    return new List<Datum>(data);
                }
            }

            void IEnumerator.Reset()
            {
                this.data = new List<Datum>(_orig);
                this.started = false;
            }

            bool IEnumerator.MoveNext()
            {
                if (!started) // enumerator begins one before beginning
                    return started = true;
                else
                    return Permute.NextPermutation(ref data);
            }

            void IDisposable.Dispose()
            {
                // nothing to do
            }

            List<Datum> IEnumerator<List<Datum>>.Current
            {
                get
                {
                    return data;
                }
            }
        }
    }

    public class PermutationsFactory
    {
        public static Permutations<Datum> makePermutations<Datum>(List<Datum> data) where Datum : IComparable
        {
            return new Permutations<Datum>(data);
        }
    }
}

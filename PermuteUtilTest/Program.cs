using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PermuteUtil;

namespace PermuteUtilTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // das ist ProjectEuler No. 24
            List<Char> digits = new List<Char>();
            for (int i = 0; i < 10; i++)
            {
                digits.Add((char)('0' + i));
            }

            var permutations = ThePermutations.of(digits);
            Console.WriteLine(String.Join("", permutations.ElementAt(999999)));
        }
    }
}

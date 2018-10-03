using System;
using System.Collections.Generic;
using System.Linq;

namespace test3.lib
{
    public class Fibonaccinumbers : ISequence
    {
        public List<int> getsequence(int len)
        {
            List<int> fib =new List<int>();
            Enumerable.Range(0, len).ToList().ForEach(f => fib.Add(f <= 1 ? 1 : fib[f - 2] + fib[f - 1]));

            return fib;       
        }
    }
}

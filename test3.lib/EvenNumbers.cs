using System;
using System.Collections.Generic;
using System.Linq;

namespace test3.lib
{
    public class EvenNumbers : ISequence
    {
        public List<int> getsequence(int len)
        {
        return System.Linq.Enumerable.Range(1, len).Where(x => x%2==0).ToList<int>();        
        }
    }
}

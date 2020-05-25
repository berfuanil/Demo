using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Addition
    {
        public Addition() { }
        public int Add(List<int> integers)
        {
            if (integers == null) 
                throw new ArgumentNullException("integers cannot be null");
            int sum = 0;
            integers.ForEach(x => sum += x);
            return sum;
        }
    }
}

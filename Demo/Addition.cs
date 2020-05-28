using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Addition
    {
        public Addition() { }
        public float Add(List<float> floats)
        {
            if (floats == null) 
                throw new ArgumentNullException("floategers cannot be null");
            float sum = 0;
            floats.ForEach(x => sum += x);
            return sum;
        }
    }
}

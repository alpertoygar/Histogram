using System.Collections.Generic;

namespace Histogram
{    
    class Histogram<A>
    {
        public Dictionary<A, int> vals;

        public Histogram()
        {
            vals = new Dictionary<A, int>();
        }

        public void Add(A a)
        {
            if (vals.ContainsKey(a))
            {
                vals[a] += 1;
            }
            else
            {
                vals[a] = 1;
            }
        }

        public void Remove(A a)
        {
            if (vals.ContainsKey(a))
            {
                vals[a] -= 1;
            }
            else
            {
                vals[a] = 0;
            }
        }

        public int Get(A a)
        {
            if (vals.ContainsKey(a))
            {
                return vals[a];
            }
            else
            {
                return 0;
            }
        }

        public bool Contains(A a)
        {
            foreach (A aa in vals.Keys)
            {
                if (aa.Equals(a))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

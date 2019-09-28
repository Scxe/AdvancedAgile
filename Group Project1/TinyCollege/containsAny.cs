using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsAny
{
    public static class ContainsAny
    {
        public static bool ListContainsAny(this string source, params string[] containsArray) // attempting to create extension method, google this.
        {
            foreach (var s in containsArray)
            {
                if (source.Contains(s))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

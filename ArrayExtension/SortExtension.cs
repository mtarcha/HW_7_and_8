using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtension
{
    static class SortExtension
    {
        public static void Sort(this int[] someArray)
        {
            Array.Sort(someArray);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray=new int[5]{5,4,3,2,1};
            someArray.Sort();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Convert.ToString(someArray[i]));
            }
            Console.ReadLine();
        }
    }
}

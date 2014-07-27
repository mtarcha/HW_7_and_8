using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Anonim
{
    class Program
    {
        const int numberOfDelegate = 2;
        delegate int int_Delegate();
        delegate double double_Delegate(int_Delegate[] s);
        static Random staticRandom = new Random();

        static void Main(string[] args)
        {
            int_Delegate[] delegates = new int_Delegate[numberOfDelegate];
            for (int i = 0; i < numberOfDelegate; ++i)
            {
                delegates[i] = new int_Delegate(() => staticRandom.Next(1000));
            }
                        
            double_Delegate f = (b) =>
            {
                return b.Average(s=>s());
            };
            Console.WriteLine(Convert.ToString(f(delegates)));
            
            Console.ReadLine();
        }
    }
}

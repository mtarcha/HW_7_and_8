using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Lambda
{
    class Program
    {
        delegate double del(double value_1,double value_2);

        static void Main(string[] args)
        {

            del sum = (value_1, value_2) => value_1 + value_2;
            del sub = (value_1, value_2) => value_1 - value_2;
            del mult = (value_1, value_2) => value_1 * value_2;
            del div = (value_1, value_2) =>  (value_2 != 0) ? (value_1 / value_2):0;         

            Console.WriteLine(Convert.ToString(sum(1,2)));
            Console.WriteLine(Convert.ToString(sub(1, 2)));
            Console.WriteLine(Convert.ToString(mult(1, 2)));
            Console.WriteLine(Convert.ToString(div(1, 0)));
            Console.WriteLine(Convert.ToString(div(1, 2)));

            Console.ReadLine();
        }
    }
}

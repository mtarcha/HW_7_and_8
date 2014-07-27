using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Article prod_1 = new Article("Meet","Goga",12.6);
            Article prod_2 = new Article("Egg", "Lola", 0.56);
            Store myStore = new Store();
            myStore.AddProduct=prod_1;
            myStore.AddProduct = prod_2;
            Console.WriteLine(myStore[1]);
            Console.WriteLine(myStore["Meet"]);
            Console.ReadLine();
        }
    }
}

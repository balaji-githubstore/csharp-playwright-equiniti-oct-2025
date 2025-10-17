using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECartApplication
{
    public class Runner
    {
        static void Main(string[] args)
        {

            //want to force the user to provide quanity 

            //Product item1 = new Product(8);

            //Console.WriteLine(item1.quanity);

            //Product item2 = new Product(40);

            Product p1 = new Product(1, "john");

            Product p2 = new Product(1.1);

            Calculator c = new Calculator();
            c.Add(4, (double)4);


            Math.Max(1, 1);
        }
    }
}

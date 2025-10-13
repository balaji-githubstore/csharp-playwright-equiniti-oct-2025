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

           Product item1=new Product(2);

            Console.WriteLine(item1.quanity);


            Product item2 = new Product(40);

        }
    }
}

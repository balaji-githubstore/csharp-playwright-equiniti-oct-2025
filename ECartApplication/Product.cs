using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECartApplication
{
    public class Product
    {
        public int id;
        public string name;
        public double price;
        public int quanity; 

        public Product(int quanity)
        {
            this.quanity = quanity;

        }


    }
}

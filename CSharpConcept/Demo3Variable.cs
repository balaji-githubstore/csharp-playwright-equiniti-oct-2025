using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Demo3Variable
    {
        public static int aS = 10;    //static variable or class variable
        public static int bS = 20;      

        public int aNS = 10;    //non-static variable or instance variable
        public int bNS = 20;

        static void Main33(string[] args)
        {
            Demo3Variable.aS = 98;

            Console.WriteLine(Demo3Variable.aS);
            Console.WriteLine(Demo3Variable.bS);


            Demo3Variable obj1=new Demo3Variable();
            Demo3Variable obj2 = new Demo3Variable();

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            obj1.aNS = 99;

            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Console.WriteLine(obj2.aNS);
            Console.WriteLine(obj2.bNS);

            Console.WriteLine(obj1.aNS);
            Console.WriteLine(obj1.bNS);

            //assign the datatype during compile time
            var a = "jack";   //a will be register for string 
            a = "kinh";

            var b= 9.2;  //b is registered for double
            b=4;

            //assign the type runtime
            dynamic z = 10.2;
            z = "king";
            z = 393993;


        }
    }
}

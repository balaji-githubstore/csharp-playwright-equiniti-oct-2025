using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    class Father
    {
        public int fAge = 70;

        public Father(int a)
        {
            fAge = 60;
            Console.WriteLine("father constructor");
        }

        public void FatherStyle()
        {
            Console.WriteLine("father style1235!!");
        }
    }

    class Son : Father 
    {
        public int sAge = 20;

        public Son(int a, int b):base(a)
        {
            sAge = 10;
            Console.WriteLine("son constructor");
        }

        public void SonStyle()
        {
            Console.WriteLine("Son style");
        }
    }



    public class InheritanceDemo
    {
        static void Main(string[] args)
        {

            Son s = new Son(90,20);

            Console.WriteLine(s.fAge);
            Console.WriteLine(s.sAge);

            s.FatherStyle();
            s.SonStyle();
           


        }
    }
}

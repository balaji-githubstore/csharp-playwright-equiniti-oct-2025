
using EQ.Math.Formulae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Demo2Methods
    {
        static void Main12(string[] args)
        {
            int radius = 10;

            //creating an object - allocates memory for all non-static variable, methods, property 
            Area obj=new Area();

            var result = obj.AreaOfCircle(10);
            Console.WriteLine(result);

            var res = Area.AreaOfRectangle(19, 10.3);
            Console.WriteLine(res);

            Console.WriteLine(Area.AreaOfRectangle(1, 3));

            res = Area.AreaOfTriangle(25, 1);
            Console.WriteLine(res);

            Console.WriteLine(Area.AreaOfSquare(8));

            string myName= obj.GetAuthorName();
            Console.WriteLine(myName);


    

            double res1= Math.Sqrt(64);
            Console.WriteLine(res1);
        }
    }
}

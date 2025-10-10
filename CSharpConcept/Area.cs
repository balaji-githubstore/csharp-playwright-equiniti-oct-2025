using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQ.Math.Formulae
{
    public class Area
    {
        //variable & methods without access modifier --> then it is considered as private
        public double AreaOfCircle(int r)
        {
            return 3.14 * r * r;
        }
        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        public static double AreaOfTriangle(double baseValue, double heightValue)
        {
            return (baseValue * heightValue) / 2;
        }

        //create method for AreaOfSquare
        public static double AreaOfSquare(double side)
        {
            return side * side;
        }

        public string GetAuthorName()
        {
            return "Balaji Dinakaran";
        }

        public void Quit()
        {
            
        }

    }
}

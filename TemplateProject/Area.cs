namespace EQ.Math.Formulae
{
    public class Area
    {
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
    }
}

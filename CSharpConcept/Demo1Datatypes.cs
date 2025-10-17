using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eq.Team.Test
{
    public class Demo1HelloWorld
    {

        static void Main1(string[] args)
        {

            sbyte myNumber = 100; //8 bits of memory is occupied
            short myNumber1 = 100; //16 bits 
            int myNumber2 = 100;  //32 bits 

            double z = myNumber2;
            //int x = z;
            long myNumber3 = 100L; //64 bits 


            //0 to 100 //1000 students 
            //byte or sbyte --> 8*1000=8000 bits 
            //int --> 32*1000=32000 bits 

            //200
            float myNumber4 = 1.123456789f;   //32 bits
            double myNumber5 = 1.123456789;   //64 bits 
            //decimal myNumber6 = 1.2m;

            char letter = '#'; //16 bits 

            bool check = true; //4 bits 

            //non-predefined datatypes 

            string myName = "Bala";  //4*16 bits 

            //10,20,30,40
            int[] numbers = new int[4]; //4*32 bits 

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;

            //Console.WriteLine(numbers.GetHashCode());

            Console.WriteLine(numbers);
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);

            double[] arr1=new double[4]; //4*64 bits 

            bool[] arr2=new bool[4]; //4*4 bits 


            //create an array to store red, green, yellow
            string[] colors=new string[3];

            colors[0] = "red";
            colors[1]="green";
            colors[2] = "yellow";

            Console.WriteLine(colors);
            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
            Console.WriteLine(colors[2]);

            string[] arr3 = { "red", "black", "yellow" };
            Console.WriteLine(arr3[1]);
            Console.WriteLine(arr3.Length);


            //Console.WriteLine(myName);
            //Console.WriteLine(myName[1]);
            //Console.WriteLine(myName.Length);
            //Console.WriteLine(myName.ToUpper());


            //Console.WriteLine(myNumber);
            //Console.WriteLine(myNumber1);
            //Console.WriteLine(myNumber2);
            //Console.WriteLine(myNumber3);


            //Console.WriteLine(myNumber4);
            //Console.WriteLine(myNumber5);

            Console.WriteLine((double)22 /7);


            string name1 = "king";

            Console.WriteLine(name1[0]);
            Console.WriteLine(name1.ToUpper());

            //will resume in 15 mins (17:45 IST)
        }
    }
}

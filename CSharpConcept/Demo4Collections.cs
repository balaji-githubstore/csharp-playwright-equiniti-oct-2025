using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Demo4Collections
    {
        static void Main(string[] args)
        {
            int c = 20;
            double c1 = 20.2;
            //string[] arr3 = { "red", "black", "yellow" };

            //for(int i=0;i<arr3.Length;i++)
            //{
            //    Console.WriteLine(arr3[i]);
            //}

            //foreach(string color  in arr3 )
            //{
            //    Console.WriteLine(color);
            //}

            //non-generic
            ArrayList lists=new ArrayList();

            lists.Add(4);
            lists.Add(5.5);
            lists.Add("jack");

            lists.Add("green");


            object a = 10;
            object b = "hello"; //boxing 

            int z = (int)a; //unboxing

            string name1 = (string) lists[2];
            Console.WriteLine(name1.ToUpper());

            //Generic type
            List<string> colors=new List<string>();

            colors.Add("red");
            colors.Add("green");
            colors.Add("yellow");

            colors.Remove("green");

            Console.WriteLine(colors[1]);
            Console.WriteLine(colors.Count);

            foreach(var val in colors)
            {
                Console.WriteLine(val);
            }

            List<int> numbers = new List<int>();


            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(101, "john");
            dic.Add(102, "peter");
            dic.Add(103, "kevin");
            dic.Add(0, "kin");
            //  dic.Add(102, "saul");


            Console.WriteLine(dic.Count);
            Console.WriteLine(dic[102]);

            foreach(int key in dic.Keys)
            {
                Console.WriteLine(dic[key]);
            }


            Dictionary<string, string> dic1 = new Dictionary<string, string>();

            dic1.Add("", "jack");
            dic1.Add("hello", "jack");
            //dic1.Add("", "jack");
        }
    }
}

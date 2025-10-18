using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    abstract class Employee
    {
        public int id;
        public string name;
        public string type;

        public void PrintEmployeeDetails()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
        }

        public virtual double CalculateSalary()
        {
            Console.WriteLine("my logic");
            return 0;
        }
    }
    class PermanentEmployee : Employee
    {
        public override double CalculateSalary()
        {
            Console.WriteLine("PermanentEmployee");
            return 40 * 30;
        }
    }
    class ContractEmployee : Employee
    {
        public override double CalculateSalary()
        {
            Console.WriteLine("ContractEmployee");
            return 45*5;
        }
    }

    public class Demo6SeleniumSample
    {
        static void Main(string[] args)
        {
            Employee e = new PermanentEmployee();

            Console.WriteLine(e.id);
            Console.WriteLine(e.name);

            e.PrintEmployeeDetails();

            double res = e.CalculateSalary(); //run time poly
            Console.WriteLine(res);


        }
    }
}

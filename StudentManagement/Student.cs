using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        private int studentId;
        public string studentName;
        private double studentPercentage;
        public static string schoolName;
        public static string schoolAddress;

        public int StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                if (value > 0)
                {
                    studentId = value;
                }
                else
                {
                    Console.WriteLine("Invalid student id - so default value remains");
                }
            }
        }

        //create only set property studentPercentage (0 to 100) 
        public double StudentPercentage
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    studentPercentage = value;
                }
                else
                {
                    Console.WriteLine("Invalid StudentPercentage - so default value remains");
                }
            }
        }

        public void PrintStudentRecord()
        {
            int studentId = 999;
            
            Console.WriteLine(this.studentId);
            Console.WriteLine(this.studentName);
            Console.WriteLine(studentPercentage);
            Console.WriteLine(Student.schoolName);
            Console.WriteLine(Student.schoolAddress);
            Console.WriteLine("---------------------------------");
        }

        public void PrintCertification()
        {
            Console.WriteLine("Hi " + studentName);
            if (studentPercentage >= 80 && studentPercentage <= 100)
            {
                Console.WriteLine("Congrats! Grade A");
            }
            else if (studentPercentage >= 60 && studentPercentage <= 79)
            {
                Console.WriteLine("Congrats! Grade B");
            }
            else if (studentPercentage >= 0 && studentPercentage < 60)
            {
                Console.WriteLine("Please reattempt!!");
            }
            else
            {
                Console.WriteLine("Invalid Percentage");
            }
        }


        public static Student GetStudentInstance()
        {
            Student stu = new Student();
            stu.studentId = 10;
            return stu;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Runner
    {
        static void Main(string[] args)
        {

            Student.schoolName = "Global";
            Student.schoolAddress = "Chennai";
            
            Student stu1=new Student();
            Student stu2=new Student();
            Student stu3=new Student();

            //load stu 1 with (101, Saul, 90, Global, Chennai)
            //stu1.studentId = 101;
            stu1.StudentId = -9;  //set property
            stu1.studentName = "Saul";
            stu1.StudentPercentage = 90;


            //load stu 2 with (102, Kim, 68, Global, Chennai)
            stu2.StudentId = 102;
            stu2.studentName = "Kim";
            stu2.StudentPercentage = -68;

            stu1.PrintStudentRecord();
            stu2.PrintStudentRecord();
            stu3.PrintStudentRecord();


            stu2.PrintCertification();
            stu1.PrintCertification();
            stu3.PrintCertification();


            //get property - read access
            Console.WriteLine(stu1.StudentId);

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");


            stu2.PrintStudentRecord();

            var res= Math.Sqrt(64);


            var stu4=Student.GetStudentInstance();
            stu4.StudentId = 103;
            stu4.studentName = "john";



           Student stu5= new Student() { StudentId = 1001, studentName = "Jack", StudentPercentage = 90.3 };

            Student stu6 = new Student();
            stu6.StudentId = 1002;
            stu6.studentName = "jack2";
            stu6.StudentPercentage = 69;


         //   Student.GetStudentInstance().StudentId = 101;


        }
    }
}

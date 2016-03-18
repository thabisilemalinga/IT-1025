using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysection3program
{
    public class Program
    {
        static void Main(string[] args)

        {
            
            Instructor Instructor1 = new Instructor("John White", "English");
            Instructor Instructor2 = new Instructor("Mike Black", "Math");
                  

            Student Student1 = new Student("Jane" ,0,Instructor1);
            Student Student2 = new Student("Joe" ,0, Instructor1);
            Student Student3 = new Student("Melisa",0, Instructor2);
            Student Student4 = new Student("Matt",0, Instructor2);

            System.Console.WriteLine("        [INSTRUCTOR GIVES STUDENTS GRADES]       ");
            System.Console.WriteLine();

            System.Console.WriteLine(Instructor1.SetStudentGrade(Instructor1,Student1, 95));
            System.Console.WriteLine(Instructor1.SetStudentGrade(Instructor1,Student2, 85));
            System.Console.WriteLine(Instructor2.SetStudentGrade(Instructor1, Student3, 90));
            System.Console.WriteLine(Instructor2.SetStudentGrade(Instructor1, Student4, 92));
            System.Console.WriteLine();

            System.Console.WriteLine("      [ STUDENTS GRADE]");
            System.Console.WriteLine();
            String Student1str = Student1.PrintStudentInformation();
            String Student2str = Student2.PrintStudentInformation();
            String Student3str = Student3.PrintStudentInformation();
            String Student4str = Student4.PrintStudentInformation();
            System.Console.WriteLine();

            System.Console.WriteLine(Student1.PrintStudentInfo());
            System.Console.WriteLine(Student2.PrintStudentInfo());
            System.Console.WriteLine(Student3.PrintStudentInfo());
            System.Console.WriteLine(Student4.PrintStudentInfo());
            System.Console.WriteLine();

            System.Console.WriteLine("    [INSTRUCTORS INFORMATION]        ");
            System.Console.WriteLine();

            string Instructor1str = Instructor1.PrintInstuctorInformation();
            string Instructor2str = Instructor2.PrintInstuctorInformation();

            System.Console.WriteLine(Instructor1str);
            System.Console.WriteLine(Instructor2str);
            System.Console.WriteLine();
            System.Console.WriteLine("     [STUDENTS INFORMATION]      ");
            System.Console.WriteLine();
            
            System.Console.WriteLine(Student1str);
            System.Console.WriteLine(Student2str);
            System.Console.WriteLine(Student3str);
            System.Console.WriteLine(Student4str);
           

            System.Console.ReadKey();

        }
    } 
  }





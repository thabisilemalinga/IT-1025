using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mysection5project

{
    class Program
    {
       public static void Main(string[] args)
        {
            while (Question.AskForString("Add new Student list? (Y/N)").ToUpper().StartsWith("Y"))
            {
            System.Console.WriteLine();
            System.Console.Write("Enter course Name?");
            System.Console.ReadLine();
            System.Console.Write("Enter course Number?");
            System.Console.ReadLine();
            System.Console.WriteLine();        
            int count = Question.AskForInteger("How many students do you want to add? ");
                System.Console.WriteLine();

                Student[] Students = new Student[count];
            

            

                for (int i = 0; i < count; i++)
                {
                    Students[i] = new Student();
                    Students[i].SetName(Question.AskForString("Enter Student Name:"));
                    Students[i].SetSNumber(Question.AskForInteger("Enter Student Number:"));

                }
                System.Console.WriteLine();

                foreach (Student Stud in Students)

                {
                    Stud.Print();
                }
                System.Console.WriteLine();


            }

            System.Console.ReadKey();
        }
                                 
                
    }
}
        
    


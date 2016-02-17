using System;

namespace mysection2project
{
    class Program
    {
        public static int SumOfAllAge { get; private set; }

        static void Main(string[] args)
        {
            
            Person p1 = new Person();
            p1.Spouse = new Person();
            Person p2 = new Person();
            p2.Spouse = new Person();

            System.Console.WriteLine("");
            System.Console.WriteLine("[ Enter Information for p1  ]");
            System.Console.WriteLine("                                       ");
            System.Console.WriteLine("Enter your first name                    :");
            System.Console.WriteLine("Enter your last name                     :");
            System.Console.WriteLine("Enter your age                           :");
            System.Console.WriteLine("Enter your spouse's first name           :");
            System.Console.WriteLine("Enter your spouse's Age                  :");



            System.Console.WriteLine("");
            System.Console.WriteLine("[ Enter Information for p2  ]");
            System.Console.WriteLine("                                       ");
            System.Console.WriteLine("Enter your first name                     :");
            System.Console.WriteLine("Enter your last name                      :");
            System.Console.WriteLine("Enter your age                            :");
            System.Console.WriteLine("Enter your spouse's first name            :");
            System.Console.WriteLine("Enter your spouse's Age                   :");


        
            System.Console.WriteLine("");
            System.Console.WriteLine("[Printing Results]");
            System.Console.WriteLine("");

        
            p1.FirstName = "Thabie";
            p1.LastName = "Malinga";
            p1.Age = 26;
            String FullName = (p1.FirstName + " " +p1.LastName);
            System.Console.WriteLine(FullName);

            p1.Spouse.FirstName="Micheal";
            p1.Spouse.LastName = "Malinga";
            p1.Spouse.Age = 30;
            FullName = (p1.Spouse.FirstName + " " + p1.Spouse.LastName);
            System.Console.WriteLine(FullName);
            
            
       
          

            p2.FirstName = "Zoleka";
            p2.LastName = "Mvundla";
            p2.Age = 27;
            FullName = (p2.FirstName + " " + p2.LastName);
            System.Console.WriteLine(FullName);

            p2.Spouse.FirstName = "Jackson";
            p2.Spouse.LastName = "Mvundla";
            p2.Spouse.Age = 32;
            FullName = (p2.Spouse.FirstName + " " + p2.Spouse.LastName);
            System.Console.WriteLine(FullName);





              SumOfAllAge = p1.Age + p2.Age + p1.Spouse.Age + p2.Spouse.Age;
              System.Console.WriteLine(p1.SumOfAllAge);
              System.Console.WriteLine(p2.SumOfAllAge);
              System.Console.WriteLine(p1.Spouse.SumOfAllAge);
              System.Console.WriteLine(p1.Spouse.SumOfAllAge);

            System.Console.WriteLine(p1.PrintNameAndAge());
             System.Console.WriteLine(p2.PrintNameAndAge());
             System.Console.WriteLine(p1.Spouse.PrintNameAndAge());
             System.Console.WriteLine(p2.Spouse.PrintNameAndAge());


            System.Console.WriteLine(SumOfAllAge/4);
              System.Console.ReadKey();


        }

        
        
           
        }
    }


namespace mysection2project
{
    class Program
    {
        public static int SumOfAllAge { get; private set; }

        static void Main(string[] args)
        {
            
            Person p1 = new Person();
            Person p2 = new Person();




            

            System.Console.WriteLine("");
            System.Console.WriteLine("[ Enter Information for p1  ]");
            System.Console.WriteLine("                                       ");
            System.Console.Write("Enter your first name                     :");
            System.Console.ReadLine();
            System.Console.Write("Enter your last name                      :");
            System.Console.ReadLine();
            System.Console.Write("Enter your age                            :");
            System.Console.ReadLine();
            System.Console.Write("Enter your Marital Status                 :");
            System.Console.ReadLine();
            System.Console.Write("Enter your spouse's first name            :");
            System.Console.ReadLine();
            System.Console.Write("Enter your spouse's Age                   :");
            System.Console.ReadLine();


            System.Console.WriteLine("");
            System.Console.WriteLine("[ Enter Information for p2  ]");
            System.Console.WriteLine("                                       ");
            System.Console.Write("Enter your first name                     :");
            System.Console.ReadLine();
            System.Console.Write("Enter your last name                      :");
            System.Console.ReadLine();
            System.Console.Write("Enter your age                            :");
            System.Console.ReadLine();
            System.Console.Write("Enter your Marital Status                 :");
            System.Console.ReadLine();
            System.Console.Write("Enter your spouse's first name            :");
            System.Console.ReadLine();
            System.Console.Write("Enter your spouse's Age                   :");
            System.Console.ReadLine();

            System.Console.WriteLine("[Printing Results]");







            p1.FirstName = "thabie";
            p1.LastName = "malinga";
            p1.Age = 26;
            p1.MaritalStatus = "married";
            p1.SpouseFirstName = "micheal";
            p1.SpouseAge = 30;
            p1.SumOfAllAge++;

            p2.FirstName = "zoleka";
            p2.LastName = "mvundla";
            p2.Age = 27;
            p2.MaritalStatus = "married";
            p2.SpouseFirstName = "jackson";
            p2.SpouseAge = 32;
            p2.SumOfAllAge++;

              System.Console.WriteLine("SumOfAllAge:+p1.count");
              System.Console.WriteLine("p2.sumOfAllAge: + p2.count");
              System.Console.WriteLine(p1.PrintNameAndAge());
              System.Console.WriteLine(SumOfAllAge / 4);



        }
    }
}

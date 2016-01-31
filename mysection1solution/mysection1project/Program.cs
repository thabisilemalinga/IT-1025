using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysection1project
{
    class Program
    {
        
        static void Main(string[] args)
        {

            string FirstName;
            string MiddleInitial;
            string LastName;
            string FullName;
            int Age;
            int HeightFeet;
            Boolean IsCitizen;
            Boolean CanVote;
            Double HeightInches;
            Double totalHeightCM;
            
            
            System.Console.Write("What is your First Name?");
            FirstName = System.Console.ReadLine();
            System.Console.Write("What is your Middle Initial?");
            MiddleInitial = System.Console.ReadLine();
            System.Console.Write("What is your Last Name?");
            LastName = System.Console.ReadLine();
            FullName = ( FirstName+" " + MiddleInitial +" "+ LastName);
            System.Console.Write("What is your Height in feet 4, 5, or 6?");
            HeightFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many inches beyond your base height in feet to add to your height?");
            HeightInches = int.Parse(System.Console.ReadLine());
            (totalHeightCM ) =((HeightFeet*12) + HeightInches) * 2.54;
            System.Console.WriteLine("Your total height is "+totalHeightCM + " centimeters");
            System.Console.Write("what is your Age?");
            Age = int.Parse(System.Console.ReadLine());
            System.Console.Write(" Are you a citizen?");
            IsCitizen = bool.Parse(System.Console.ReadLine());
            if ((Age >= 18) && (IsCitizen = true)) ;
            {
                System.Console.Write(" You can vote");
            }
            else
            { 
                System.Console.Write(" You cant vote, sucks to be you loser...");
            };

            System.Console.WriteLine(FullName);
            System.Console.WriteLine(totalHeightCM);
            System.Console.WriteLine(IsCitizen);
            
            System.Console.ReadKey();


            

        }
    }
}

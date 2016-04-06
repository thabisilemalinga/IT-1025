using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysection4project
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("     MOVIE PRICES AND DISCOUNTS         ");
            System.Console.WriteLine();
            System.Console.WriteLine("If you would like to know how much you would spend in our movie theatre put your details below!!!");
            System.Console.WriteLine();

            

             double child_ticket_price = 6.99;           //default to Evening price
             double adult_ticket_price = 10.99;           //default to Evening price
             double senior_ticket_price = 8.50;           //default to evening price
             double child_ticket_total_price =0;
             double adult_ticket_total_price =0;
             double senior_ticket_total_price =0;
            


            System.Console.Write("What Show do you want to see enter M for Matinee or E for Evening? ");
            string showtime = Console.ReadLine();
            
            if (showtime == "M")
            {
                 child_ticket_price = 3.99;
                 adult_ticket_price = 5.99;
                 senior_ticket_price = 4.50;
            }





            if (showtime == "E")
            {
                child_ticket_price = 6.99;        
                adult_ticket_price = 10.99;         
                senior_ticket_price = 8.50;           

            }

            System.Console.Write("How Many Children's tickets do you want? ");
            int child_tickets_qty = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            
              if (child_tickets_qty > 0)
            {
                child_ticket_total_price = child_tickets_qty * child_ticket_price;
                System.Console.WriteLine(child_ticket_total_price);
            }
            

            System.Console.Write("How Many Adult tickets do you want? ");
            int adult_tickets_qty = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

               if (adult_tickets_qty > 0)
            {
                adult_ticket_total_price = adult_tickets_qty * adult_ticket_price;
                System.Console.WriteLine(adult_ticket_total_price);
            }

          

            System.Console.Write("How Many Senior's tickets do you want: ");
            int senior_tickets_qty = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

                if (senior_tickets_qty > 0)
            {
                senior_ticket_total_price = senior_tickets_qty * senior_ticket_price;
                System.Console.WriteLine(senior_ticket_total_price);
            }



            double total_ticket_qty = child_tickets_qty + adult_tickets_qty + senior_tickets_qty;
            double total_ticket_price = child_ticket_total_price  + adult_ticket_total_price + senior_ticket_total_price;

            System.Console.Write("How Many Small sodas? ");
            int small_soda_qty = int.Parse(Console.ReadLine());
            double total_small_soda_price = small_soda_qty * 3.50;

            System.Console.Write("How Many Large sodas? ");
            int large_soda_qty = int.Parse(Console.ReadLine());


            System.Console.Write("How Many Popcorn?");
            int popcorn_qty = int.Parse(Console.ReadLine());

            System.Console.Write("How Many Hot dogs?");
            int hot_dog_qty = int.Parse(Console.ReadLine());


            System.Console.Write("How Many Candies? ");
            int candy_qty = int.Parse(Console.ReadLine());

            if (candy_qty >= 3)
            { System.Console.WriteLine("You get a free candy");
               System.Console.WriteLine();
            }

            if (total_ticket_qty + large_soda_qty + popcorn_qty > 0)
            {
                System.Console.WriteLine("Get a $2 dicount on the movie ticket");
                System.Console.WriteLine();

            }

            if (total_ticket_qty >= 3 && showtime=="E")
            {
                             
              System.Console.WriteLine("You get a free bag of popcorn");
                System.Console.WriteLine();

            }



            System.Console.WriteLine("If you wish to proceed with the purchase");
            System.Console.Write("Press  Enter to continue... ");
            System.Console.ReadKey();
        }

    }
    }



    


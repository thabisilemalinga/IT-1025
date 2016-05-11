using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_project
{
    class Program
    {
        static void Main(string[] args)
        {
            bool elevator1IsOverMaxCapacity;
            bool elevator2IsOverMaxCapacity;

            Passenger A1 = new Passenger("A1", 180);
            Passenger A2 = new Passenger("A2", 220);

            Elevator elevator1 = new Elevator(2, 400);
            elevator1.AddOccupant(A1, 0);
            elevator1.AddOccupant(A2, 1);

            elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();
            Passenger E2A1 = new Passenger("A1", 220);
            Passenger E2A2 = new Passenger("A2", 200);
            Passenger E2A3 = new Passenger("A3", 201);


            Elevator elevator2 = new Elevator(3, 600);
            elevator2.AddOccupant(E2A1, 0);
            elevator2.AddOccupant(E2A2, 1);
            elevator2.AddOccupant(E2A3, 2);

            elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();



        }
    }
    }


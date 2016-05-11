using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_project
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;


        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }
        public void AddOccupant(Passenger passenger, int index)
        { Occupants.SetValue(passenger, index); }

        public double GetCurrentWeight()
        {

            double totweight;

            totweight = 0;


            for (int i = 0; i < Occupants.Length; i++)
            {
                totweight = totweight + Occupants[i].GetWeight();
            }
            return totweight;
        }


        public bool IsOverMaxCapacity()
        {
            if (GetCurrentWeight() > MaxWeight)
            { return true; }
            else
            { return false; }
        }
    }
}


        

        





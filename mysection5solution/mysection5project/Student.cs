using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysection5project
{
    class Student
    {
       
        private string StudentName;
        public string GetName() { return StudentName; }
        public void SetName(string Name) { StudentName = Name; }
       
        private int StudentNumber;
        public int GetSNumber() { return StudentNumber; }
        public void SetSNumber(int SNumber) { StudentNumber= SNumber; }

        public void Print()
        {
            System.Console.WriteLine( this.GetName() + "- " + this.GetSNumber());
        }

    }
}




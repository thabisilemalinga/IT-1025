using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysection3program
{
    public class Student
    {
        private string Name;
        private int Grade ;
        private Instructor Instructor;

        public Student(string theirname,int Grade, Instructor theirInstructor)
        { 
            this.Name = theirname;
            this.Grade = Grade=0;
            this.Instructor = theirInstructor;
            
        }

        
        public void SetGrade(Student Student, int Grade)
        {
            //       return this.Name + this.Grade;
            this.Grade = Grade; 
        }
   
        public string PrintStudentInformation()
        {
            return this.Name +  " = " + this.Grade +"  "+ "Instructor = "+ this.Instructor.PrintInstuctorName();
    }
        public string PrintStudentName()
        {
            return this.Name;
        }

        public string PrintStudentInstructor()
        {
           return this.Instructor.PrintInstuctorName();
        }

        public string PrintStudentInfo()
        {
            return this.Name + " = " + this.Grade ;
        }

    } 

        
        
            
          
        
        
       
            
    
}

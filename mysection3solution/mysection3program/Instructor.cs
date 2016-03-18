using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysection3program
{
    public class Instructor
    {
        private string Name;
        private string CourseName;
        Student Student;

        public Instructor(string theirname, string theircoursename)
        {
            this.Name = theirname;
            this.CourseName = theircoursename;
        }


        public string SetStudentGrade(Instructor Instructor,Student Student, int Grade)
        {
               
            Student.SetGrade(Student, Grade);
            return this.Name + " gives " + Student.PrintStudentName()+" "+ Grade;
        }

        public string PrintInstuctorName()
        {
            return Name ;
        }


        public string PrintInstuctorInformation()
    {
        return Name +  "=" + CourseName;
        }
     
  
}
}

namespace mysection2project
{
    class Person
    {

        public string FirstName, LastName, MaritalStatus, SpouseFirstName;
        public int Age, SpouseAge;
        public double SumOfAllAge;
        public static int count;
       
        public Person Spouse;
        public string PrintNameAndAge()
        {
            return this.FirstName + "" + Age;

        }







    }
}
namespace code_example_in_c_sharp
{
    public class Teacher
    {
        private string firstName;
        private string lastName;
        private string subject;
        private enum Position { assistant, seniorLecturer, associateProfessor, professor };
        private int salary = 10000;
        private int scientificSupervisorofStudents;
        private static string department = "ПИиКТ";

        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName, string subject, int salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.subject = subject;
            this.salary = salary;
        }

        public string Subject
        {
            get { return subject; }
        }

        public string FirstName 
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        private string GetInfoFull()
        {
            return firstName + " " + lastName + ", " + "дисциплина: " + subject + ", оклад: " + salary + " рублей.";
        }

        public string GetInfo()
        {
            return firstName + " " + lastName + ", " + department;
        }
    }
}

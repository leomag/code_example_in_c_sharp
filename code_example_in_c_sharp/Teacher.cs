namespace code_example_in_c_sharp
{
    public class Teacher
    {
        public Teacher()
        {
            
        }
        private string firstName;
        private string lastName;
        private string subject;
        private enum Position { assistant, seniorLecturer, associateProfessor, professor };
        private int salary;
        private int scientificSupervisorofStudents;

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

        public string СonductsLecture()
        {
            return firstName + " " + lastName + ", " + "дисциплина: " + subject + ", оклад: " + salary + " рублей.";
        }
    }
}

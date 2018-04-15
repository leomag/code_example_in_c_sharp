using System;

namespace code_example_in_c_sharp
{
    class MainTeacher
    {
        public static void Main(string[] args)
        {
            Teacher assistant = new Teacher("Илья", "Исаев", "тестирование программного обеспечения", 34000);
            Console.WriteLine(assistant.GetInfoFull());
            Console.WriteLine(assistant.GetInfo());
        }
    }
}

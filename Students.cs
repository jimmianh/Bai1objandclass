using System;

namespace Bai1ClassObject
{
    class Students
    {
        string _studName = "James Aderson";
        int age = 27;

        void Display()
        {
            Console.WriteLine("Student name:"+ _studName);
            Console.WriteLine("Student Age:"+age);
        }

        static void Main(string[] args)
        {
            Students students = new Students();
            students.Display();
        }
    }
}

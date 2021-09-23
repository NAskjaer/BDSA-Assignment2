using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.Student test1 = new Library.Student(0, "New", "Student", new DateTime(2021,9,23), new DateTime(2024,9,24), new DateTime(2024,9,24));
            Console.WriteLine(test1.ToString());


            Library.ImmutableStudent test2 = new Library.ImmutableStudent(0, "New", "Student", new DateTime(2021,9,23), new DateTime(2024,9,24), new DateTime(2024,9,24));
            Console.WriteLine(test2.ToString());
        
        }
    }
}

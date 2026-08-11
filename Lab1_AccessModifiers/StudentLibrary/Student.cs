using System;
namespace StudentLibrary
{
    public class Student
    {
        public string Name = "Aarush";
        private int Age = 22;
        protected string Department = "Computer Applications";
        internal double CGPA = 8.5;
        protected internal string College = "Gla University";
        private protected string Address = "Uttar Pradesh";
        public void Display()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("Department:" + Department);
            Console.WriteLine("CGPA:" + CGPA);
            Console.WriteLine("College:" + College);
            Console.WriteLine("Address:" + Address);
        }

    }
}
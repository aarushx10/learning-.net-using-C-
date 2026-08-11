using System;

namespace Lab1_AccessModifiers
{
    class Student
    {
        public string Name = "Aarush";

        private int Age = 22;

       protected string Department = "Computer Applications";

       internal double CGPA = 8.5;

       protected internal string College = "GLA UNIVERSITY";

       private protected string Address = "Uttar Pradesh";
        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("CGPA: " + CGPA);
            Console.WriteLine("College: " + College);
            Console.WriteLine("Address: " + Address);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();

            //student.Display();

            //Console.ReadLine();

            //TestStudent test = new TestStudent();
            //test.TestAccess();
            //Console.ReadLine();

            GraduateStudent graduateStudent = new GraduateStudent();
            graduateStudent.ShowData();
            Console.ReadLine();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_AccessModifiers
{
    internal class GraduateStudent
    {
        public void ShowData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("CGPA: " + CGPA);
            Console.WriteLine("College: " + College);
            Console.WriteLine("Address:" + Address);

            Student student = new Student();
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Age:" + student.Age);
            Console.WriteLine("Department: " + student.Department);
            Console.WriteLine("CGPA:" + student.CGPA);
            Console.WriteLine("College" + student.College;

        }
    }
}

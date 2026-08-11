using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_AccessModifiers
{
    class TestStudent
    {
        public void TestAccess() { 
            Student student = new Student();
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.CGPA);
            Console.WriteLine(student.Department);
            Console.WriteLine(student.College);
            Console.WriteLine(student.Address);
    }
    }

}

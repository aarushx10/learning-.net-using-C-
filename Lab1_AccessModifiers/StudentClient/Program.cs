using System;
using StudentClient;
using StudentLibrary;
class Program
{
    static void Main(String[] args)
    {
        //Student student = new Student();
        //Console.WriteLine("Name:" + student.Name);
        //Console.ReadLine();
        ResearchStudent researchStudent = new ReserachStudent();
        researchStudent.ShowData();
        Console.ReadLine();

    }
}
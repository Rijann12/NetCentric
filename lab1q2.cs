using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//2.Write a C# program to display student Id and Name using automatic properties.
namespace lab1q2
{
    internal class Program
    {
        class Student
        {
            public String Name
            {
                get;
                set;
            }
            public int Id
            {
                get;
                set;
            }
            public Student(String name, int id)
            {
                Name = name;
                Id = id;
            }
            public void display()
            {
                Console.WriteLine($"My name is {Name} and my ID is {Id}");
            }
            static void Main(string[] args)
            {
                Student s = new Student("Rijan", 22081038);
                s.display();
            }
        }
    }
}

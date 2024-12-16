using System;

namespace lab1q4
{
    internal class Indexer
    {
        class StudentList
        {
            private string[] studentNames;

            public StudentList(int size)
            {
                studentNames = new string[size];
            }

            // Indexer to store and retrieve student names using an index
            public string this[int index]
            {
                get
                {
                    // Check for valid index
                    if (index >= 0 && index < studentNames.Length)
                    {
                        return studentNames[index];
                    }
                    else
                    {
                        return "Invalid index";
                    }
                }
                set
                {
                    // Check for valid index
                    if (index >= 0 && index < studentNames.Length)
                    {
                        studentNames[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid index. Cannot assign name."); // Error message for invalid index
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            StudentList students = new StudentList(3);

            students[0] = "cartT";
            students[1] = "Magnus";
            students[2] = "DP";

            Console.WriteLine("Student at index 0: " + students[0]);
            Console.WriteLine("Student at index 1: " + students[1]);
            Console.WriteLine("Student at index 2: " + students[2]);

            Console.WriteLine("Student at index 5: " + students[5]);

            Console.ReadKey();
        }
    }
}
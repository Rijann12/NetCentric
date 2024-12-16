using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SumCalculator
{
    private int number1;
    private int number2;

    // Constructor to initialize the numbers
    public SumCalculator(int num1, int num2)
    {
        number1 = num1;
        number2 = num2;
    }

    // Method to calculate the sum
    public int CalculateSum()
    {
        return number1 + number2;
    }
}

namespace DotNetLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Input two numbers
                Console.WriteLine("Enter the first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                // Create an object of SumCalculator and pass the numbers
                SumCalculator calculator = new SumCalculator(num1, num2);

                // Calculate and display the sum
                int sum = calculator.CalculateSum();
                Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
            }
        }
    }
    


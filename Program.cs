using System;

namespace lab1q3
{
    internal class Array
    {
        static void Main(string[] args)
        {
            // Define and initialize an array
            int[] numbers = { 1, 2, 3, 4 };

            Console.WriteLine("Original Array:");
            // Print the original array
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            // Call the ReverseArray function to reverse the array
            ReverseArray(numbers);

            Console.WriteLine("\nReversed Array:");
            // Print the reversed array
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }

        // Function to reverse the array
        static void ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            // Swap elements from start and end until the middle of the array is reached
            while (start < end)
            {
                // Swap the elements
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                // Move the pointers towards the center
                start++;
                end--;
            }
        }
    }
}
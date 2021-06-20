using System;

namespace Friday_Activity_Week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Universe");

            /*
Decl        are an array of 7 elements.Take input from user to initialize the array and count the 0s(Zeros) in the array.
            */

            Console.WriteLine("Task 1");
            // Task 1 Declare and initialize array of 10 integers.Then print only the odd number elements.

            int[] num_array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < num_array.Length; i++)
                if (num_array[i] % 2 != 0)
                {
                    Console.WriteLine(num_array[i]);
                }

            Console.WriteLine("");
            Console.WriteLine("Task 2");
            // Task 2 Declare and initialize array of 10 integers then print the multiplication table of each element in the array.

            //int[] num_array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < num_array.Length; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 12; j++)
                {
                    Console.WriteLine(Convert.ToString(num_array[i]) + " x " + Convert.ToString(j + 1) + " = " + Convert.ToString(num_array[i] * j + 1));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Task 3");
            //Declare and initialize array of 8 characters then print the character elements in reverse order. (From last element to first element)

            string[] char_array = { "a", "b", "c", "d", "e", "f", "g", "h" };

            for (int i = char_array.Length - 1; i >= 0; i--)
                Console.WriteLine(char_array[i]);


            Console.WriteLine("");
            Console.WriteLine("Task 4");
            //Declare an array of 7 elements.Take input from user to initialize the array and count the 0s(Zeros) in the array.

            string[] input_array = new string[7];

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Input something");
                input_array[i] = Console.ReadLine();
            }

            int counter = 0;
            for (int i = 0; i < 7; i++)
            {
                if (input_array[i] == "0")
                    counter += 1;
            }
            Console.WriteLine("There are " + Convert.ToString(counter) + " instances of the value 0");
        }
    }
}

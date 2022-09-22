// Developer: An Nguyen

using System;
namespace deliverable5
{
    class Program
    {
        // Declare Method 1
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }

            return MyArray;
        }

        //Declare Method 2
        static int array_summation(int[] MyArray)
        {
            int sum = 0;
            for (int i = 0; i < MyArray.Length; i++ )
            {
                sum += MyArray[i];
            }

            return sum;
        }
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer number between 5 and 15: ");
                int input = int.Parse(Console.ReadLine());

                // Conditional Statement to valdate user's input
                if (input <= 15 && input >= 5)
                {
                    int[] MyArray = random_array(input);

                    Console.WriteLine("The elements in the random array are: ");
                    foreach (int i in MyArray)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine(" ");

                    Console.WriteLine("The sum is: " + array_summation(MyArray));
                }
                else
                {
                    Console.WriteLine("Please insert an integer in the range from 5 to 15 only.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid integer number.");
            }
        }
    }
}
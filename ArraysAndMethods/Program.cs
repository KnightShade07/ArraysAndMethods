using System;
using System.Transactions;

namespace ArraysAndMethods
{
    class Program
    {
        //***Write the program without any class scoped variables***

        static void Main(string[] args)
        {
            enterNumberList();
            displayArray();
        }
        //This method repeatedly asks a user for a number (up to 10 total numbers) or they can stop early by entering 0.
        public static int[] enterNumberList()
        {
            bool enterNums = true;
            Console.WriteLine("Enter some numbers, you can enter up to 10, enter 0 to quit early.");
            while(enterNums)
            {
                  string numInput = Console.ReadLine();
                  if(numInput == "0")
                   {
                     enterNums = false;
                   }
            }

            int[] numbers = { };
            return numbers;
        }
        //This method takes an array as a parameter, copies that array and doubles each element, and returns the copy array.
        public static int[]copyArrayAndDouble(int[]numbers)
        {
            int[] doubledCopyArray = { };
            return doubledCopyArray;
        }
        //This method displays the original array and the copy array with the doubled values afterwards.
        public static int[] displayArray(/*Takes the two arrays as parameters.*/)
        {
            return displayArray();
        }
    }
}

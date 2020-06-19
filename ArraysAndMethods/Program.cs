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
            //displayArray();
        }
        //This method repeatedly asks a user for a number (up to 10 total numbers) or they can stop early by entering 0.
        public static int[] enterNumberList()
        {
            int[] numbers = new int[10];
            //placeholder value for the user's integers.
            int x = 0;
            //placeholder string for the user's integers.
            string enterNumsString = "";

            int numCounter = -1;
            bool enterNums = true;

            Console.WriteLine("Enter some numbers, you can enter up to 10, enter 0 to quit early.");
            while(enterNums)
            {
                if(enterNumsString == "0")
                {
                  enterNums = false;
                }
                else
                {
                    enterNumsString = Console.ReadLine();
                    numbers[x] = Convert.ToInt32(enterNumsString);
                    x++;
                    numCounter++;
                }

                if (numCounter == 10)
                {
                    enterNums = false;
                }

                
            }

            for(int i = 0; i > numbers.Length; i++)
            {
                Console.WriteLine(numbers);
            }

            
            return numbers;
        }
        //This method takes an array as a parameter, copies that array and doubles each element, and returns the copy array.
       /* public static int[]copyArrayAndDouble(int[]numbers)
        {
           
            return doubledCopyArray;
        } */

        //This method displays the original array and the copy array with the doubled values afterwards.
        public static int[] displayArray(/*Takes the two arrays as parameters.*/)
        {
            return displayArray();
        }
    }
}

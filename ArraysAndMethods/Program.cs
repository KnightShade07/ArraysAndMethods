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
        }
        //This method repeatedly asks a user for a number (up to 10 total numbers) or they can stop early by entering 0.
        public static void enterNumberList()
        {
            int[] numbers = new int[10];
            //keeps track of how many numbers the user has inputted.
            int numCounter = 0;
            //placeholder string for the user's integers.
            string enterNumsString = "";

            
            bool enterNums = true;

            Console.WriteLine("Enter some numbers, you can enter up to 10, enter 0 to quit early.");
            while(enterNums)
            {
                enterNumsString = Console.ReadLine();
                if (enterNumsString == "0")
                {
                  enterNums = false;
                }
                else
                {
                    
                    numbers[numCounter] = Convert.ToInt32(enterNumsString);
                    numCounter++;
                }

                if (numCounter == 10)
                {
                    enterNums = false;
                }
                
                
            }

            int[] numCounterArray = new int[numCounter];
            //Tests output of array
            for(int i = 0; i < numCounter; i++)
            {
                numCounterArray[i] = numbers[i];
            }
            Console.WriteLine("");

            //calls the copyArrayAndDouble method with numCounterArray as its parameter.
            CopyArrayAndDouble(numCounterArray);
        }
        //This method takes an array as a parameter, copies that array and doubles each element, and returns the copy array.
        public static void CopyArrayAndDouble(int[]numCounterArray)
        {
            int[] doubledCopyArray = new int[numCounterArray.Length];
            for (int i = 0; i < numCounterArray.Length; i++)
            {
                //sets the doubled copied array to the values of numCounterArray * 2.
                doubledCopyArray[i] = numCounterArray[i] * 2;
            }
            //sets the parameters for display array.
            displayArray(numCounterArray, doubledCopyArray);
        } 

        //This method displays the original array and the copy array with the doubled values afterwards.
        public static void displayArray(int[]numCounterArray, int[]doubledCopyArray)
        {
            for (int i = 0; i < numCounterArray.Length; i++)
            {
                Console.WriteLine(numCounterArray[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i < numCounterArray.Length; i++)
            {
                Console.WriteLine(doubledCopyArray[i]);
            }
        }
    }
}

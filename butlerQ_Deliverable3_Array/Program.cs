using System;

namespace butlerQ_Deliverable3_Array
{
    /*
    Author: Quinn Butler
    Date: 2/5/2021
    Comments: C# console application that creates an array, adds 25 integers in array, and ends application
    */
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Watch the video posted in CANVAS on: Arrays
            Review the source codes on the GitHub link. Then write the following program:
            PROGRAM #1: Create a C# console application that demonstrates an Array with the following instructions:
            1. Choose either type of array (Manually populated for Auto populated) seen in the example
            2. The program doesn't ask the user anything, it will just run and execute code. No user input.
            3. Have the program execute an array that is of size 25 elements.
            4. Then, have the code simply display in the Console the following 25 times (Here is a sample of the output):
            Element value = 1
            Element value = 2
            Element value = 3
            .......... and so on .....
            Element value = 25
            Once you complete this program, upload them to GitHub.
            Then, paste your 2 GitHub Link to GitHub here.
             */
            //Declare array that we're populating
            int[] intArray = new int[25];
            //Declare count variable
            int count;
            //Use iterative for loop for adding +1 to count very step and adds that value to the int Array
            for (count = 0; count < intArray.Length; count++)
            {
                intArray[count] = count+1;
                //Prints value for value that was added
                Console.WriteLine("Element value = " + (count+1));
            }
            //print text for program ending
            Console.WriteLine("Program end");
            //For this case, program does print text in console and ends, but for troubleshooting the last two lines can be deleted to confirm that the lines
            //print correctly
            //Console.WriteLine("Please press any key to exit console.");
            //Console.ReadKey(true);
        }
    }
}

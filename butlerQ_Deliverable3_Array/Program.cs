using System;

namespace butlerQ_Deliverable3_Array
{
    class Program
    {
        static void Main(string[] args)
        {
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

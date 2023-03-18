using System; //Calling system funtions
using System.Text; //Calling System subclasses if needed
using System.Threading.Tasks;
using System.Text.RegularExpressions;

public class Height //setting class as Cylinder for program
{
     
    static void Main()
    {
        string value; // storing value for program restart y/n
            do // Running program through do so that program can be restarted
            {
                int[] array = new int[5] { 1, 2, 3, 4, 5 };  // Creating an array with 1-5 stored in it & specifying 5 objects in the array

                for (int i = 0; i < array.Length; i++) { // Running the loop until the end of the array is met & increasing the value each time the loop runs.
                    Console.WriteLine(array[i]); // outputting the array value
                }

                Console.Write("Do you want to do another calculation?(y/n):");
                value = Console.ReadLine()!;
                if (value == "y" || value == "Y") {
                    Console.WriteLine("Continuing...");
                }
            }
            while (value=="y" || value=="Y"); // Program will restart as long as value is equal to Y/y from the start of the do
    }
    
}
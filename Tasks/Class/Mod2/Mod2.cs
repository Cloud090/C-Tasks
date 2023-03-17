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
                int height; // Declaring variable to store height
                Console.WriteLine("Enter your height: (CM)"); // Prompting user for input
                string heightVerify = Console.ReadLine()!; // Recieving user input and storing as a string
                bool isNumerical = int.TryParse(heightVerify, out height); // Verifying it's a number and passing to height variable if number

                while (isNumerical = false || height <= 0 || height > 500) { // If the user input is not a number or an invalid number it will enter whis loop
                    Console.WriteLine("That's not a valid number! Try Again: "); // Output telling the user the input is invalid
                    heightVerify = Console.ReadLine()!; // checking input again
                    isNumerical = int.TryParse(heightVerify, out height); // verifying it's a number
                }

                if (height > 200) { // If the number is more than 200cm it will enter this statement
                    Console.WriteLine("You are tall!"); // Telling the user their tall
                }
                else if (height >= 100) { // If the user is taller than 100cm it will enter this statement
                    Console.WriteLine("You are normal"); // Tells the user they are normal
                }
                else if (height > 0 && height <100) { // If shorter than 100cm it will enter this statement
                    Console.WriteLine("You are shorter than average"); // Tells the user they are below average
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
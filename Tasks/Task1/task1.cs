using System;
using System.Text;
using System.Threading.Tasks;

public class Calculator //Declairing app Calculator
{
     
    static void Main()
    {
        string value; //Setting the value to check if the user wants to run another calculation
            do // Doing the actions within here whilst value = Y/y
            {
                
                Console.WriteLine ("Input 1:"); //Giving user prompt to enter the first number
                string input1Verify = Console.ReadLine()!; //reading the input saving in a verify variable string
                int input1; // int input1 will convert the verify variable to this if no errors
                

                bool isNumerical = int.TryParse(input1Verify, out input1); // Trying to convert input1Verify to an int and to input1 var

                while (isNumerical == false) { // If there is an error converting to int enters this loop
                    Console.WriteLine("Oh no, that's not a number! Try Again:"); // Prompt to make the user aware the input failed and to try again
                    input1Verify = Console.ReadLine()!; // Taking another input
                    isNumerical = int.TryParse(input1Verify, out input1); // trying to convert again
                }
                Console.WriteLine("First Input is: " + input1); // Feedback to tell the user the recognised input

                Console.WriteLine ("Input 2:"); // Prompt for second number
                string input2Verify = Console.ReadLine()!; // Running the same process as for input 1 from here
                int input2;
                
                bool isNumerical2 = int.TryParse(input2Verify, out input2)!;

                while (isNumerical2 == false) {
                    Console.WriteLine("Oh no, that's not a number! Try Again:");
                    input2Verify = Console.ReadLine()!;
                    isNumerical2 = int.TryParse(input2Verify, out input2);
                }
                Console.WriteLine("Second Input is: " + input2);
                
                int multiply = input1 * input2; // declaring variable as integer & Multiplying inputted numbers
                int add = input1 + input2; // Adding Inputted numbers
                int subtract = input1 - input2; //Subtracting Inputted numbers
                int divide = input1 / input2; // Dividing inputted numbers
                
                // Outputting all results line by line for user to see
                Console.WriteLine("Results:"); //Labeling the following as the results clearly
                Console.WriteLine("Multiplication: " + input1 + " X " + input2 + " = " + multiply); //Displaying maths method & user inputs with answers for multiplication,subtraction,addition & division
                Console.WriteLine("Addition: " + input1 + " + " + input2 + " = " + add);
                Console.WriteLine("Subtraction: " + input1 + " - " + input2 + " = " + subtract);
                Console.WriteLine("Division: " + input1 + " / " + input2 + " = " + divide);
                
                // Asking the user if they want to restart with a new calculation
                Console.Write("Do you want to do another calculation?(y/n):");
                value = Console.ReadLine()!; // Storing their answer
                if (value == "y" || value == "Y") {
                    Console.WriteLine("Continuing..."); // Printing continuing to give feedback the program is restarting
                }
                else {
                    Console.WriteLine("Shutting down. . ."); // Printing shut down if the user wants to end the program
                }
                
                
            }
            while (value=="y" || value=="Y"); // while value = Y/y it will restart the do loop
    }
    
}
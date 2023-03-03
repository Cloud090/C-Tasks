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
                
                decimal multiply; // Setting calculation types to be used as decimal so it can handle all numbers
                decimal divide;
                decimal add;
                decimal subtract;

                Console.WriteLine ("Input 1:"); //Giving user prompt to enter the first number
                string input1Verify = Console.ReadLine()!; //reading the input saving in a verify variable string
                decimal input1; // int input1 will convert the verify variable to this if no errors
                

                bool isNumerical = decimal.TryParse(input1Verify, out input1); // Trying to convert input1Verify to a decimal and to input1 var

                while (isNumerical == false) { // If there is an error converting to decimal program enters this loop until input is valid
                    Console.WriteLine("Oh no, that's not a number! Try Again:"); // Prompt to make the user aware the input failed and to try again
                    input1Verify = Console.ReadLine()!; // Taking another input
                    isNumerical = decimal.TryParse(input1Verify, out input1); // trying to convert again
                }
                Console.WriteLine("First Input is: " + input1); // Feedback to tell the user the recognised input

                Console.WriteLine ("Input 2:"); // Prompt for second number
                string input2Verify = Console.ReadLine()!; // Running the same process as for input 1 from here
                decimal input2; // Declaring the second input variable
                
                bool isNumerical2 = decimal.TryParse(input2Verify, out input2)!; //trying to convert user input to a decimal

                while (isNumerical2 == false) { // If there is an error converting to decimal program enters this loop until input is valid
                    Console.WriteLine("Oh no, that's not a number! Try Again:"); // Prompt to make the user aware the input failed and to try again
                    input2Verify = Console.ReadLine()!; // Taking another input
                    isNumerical2 = decimal.TryParse(input2Verify, out input2); // trying to convert again
                }
                Console.WriteLine("Second Input is: " + input2); // Feedback to tell the user the recognised input

                    multiply = input1 * input2; // Multiplying inputted numbers & storing in variable
                    add = input1 + input2; // Adding Inputted numbers & storing in variable
                    subtract = input1 - input2; //Subtracting Inputted numbers & storing in variable

                // Outputting all results line by line for user to see
                Console.WriteLine("Results:"); //Labeling the following as the results clearly
                Console.WriteLine("Multiplication: " + input1 + " X " + input2 + " = " + multiply); //Displaying maths method & user inputs with answers for multiplication,subtraction,addition & division
                Console.WriteLine("Addition: " + input1 + " + " + input2 + " = " + add);
                Console.WriteLine("Subtraction: " + input1 + " - " + input2 + " = " + subtract);
                /* Dividing by 0 causes an error and the program to close. In order to prevent the program exiting it checks the user input and if
                the second input is 0 it will let the user know its a math error and print the outputs for everything else */
                if (input2 == 0) {

                    Console.WriteLine("Division: " + input1 + " / " + input2 + " = " + " Math Error! Cannot divide by 0");
                }
                else { // If second input is not 0 it will enter this else statement and calculate the division of the 2 inputs
                    
                    divide = input1 / input2; // Dividing inputted numbers
                    Console.WriteLine("Division: " + input1 + " / " + input2 + " = " + divide); // Outputting result
                }
                

                multiply = input1 * input2; // declaring variable as integer & Multiplying inputted numbers
                add = input1 + input2; // Adding Inputted numbers
                subtract = input1 - input2; //Subtracting Inputted numbers
                // Asking the user if they want to restart with a new calculation
                Console.Write("Do you want to do another calculation?(y/n):");
                value = Console.ReadLine()!; // Storing their answer
                if (value == "y" || value == "Y") { // checking if y is entered in either capital or lowercase
                    Console.WriteLine("Continuing..."); // Printing continuing to give feedback the program is restarting
                }
                else {
                    Console.WriteLine("Shutting down. . ."); // Printing shut down if the user wants to end the program
                }
                
                
            }
            while (value=="y" || value=="Y"); // while value = Y/y it will restart the do loop
    }
    
}
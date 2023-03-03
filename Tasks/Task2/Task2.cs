using System; // Calling libaries
using System.Text;
using System.Threading.Tasks;

public class Grade // Setting app proccess as Grade
{
    static void Main()
    {
        string value; // creating variable to check if user wants to do another calculation
            do
            {

                Console.WriteLine("Score:"); // Prompt for the user to //  enter the score
                string scoreVerify = Console.ReadLine()!; // Variable to pass user input into initially
                int score; // Variable to pass user input once validated
                bool isNumerical = int.TryParse(scoreVerify, out score); // trying to pass input to int and to score variable
                // If user input is not a number &/or a number is above 100 or below 0 it will enter this loop until the input is valid
                while (isNumerical == false || score < 0 || score > 100) { 
                    Console.WriteLine("Oh no, that's not a valid score. Try Again:"); // Printing out for the user that input is invalid & prompt to try again
                    scoreVerify = Console.ReadLine()!; // Getting new input
                    isNumerical = int.TryParse(scoreVerify, out score); // Checking if input is a number(int)
                }

                Console.WriteLine("Score is: " + score); // Printing the entred score to the user
                    
                // Will enter the statement below based on what one the user inputted score fits into
                if (score >= 85 & score <= 100) {
                    Console.WriteLine(score +" = High Distinction");  
                }
                else if (score >= 75 & score <= 84) {
                    Console.WriteLine(score + " = Distinction");
                }
                else if (score >= 65 & score <= 74){
                    Console.WriteLine(score +" = Credit");
                }
                else if (score >= 55 & score <=64) {
                    Console.WriteLine(score +" = Pass");
                }
                else if (score >= 0 & score <= 54) { // Using else if so it checks if it matches the first if then first else if etc until it finds a match
                    Console.WriteLine(score +" = Fail");
                }
                
                
                
                Console.Write("Do you want to do input another score?(y/n):"); // Prompt for the user
                value = Console.ReadLine()!; //reading user input
                if (value =="y" ||value=="Y"){ // Prints if user wants to coninue confirmed if user entres Y/y
                    Console.WriteLine("Continuing...");
                }
                else { // prints if y is not inputted
                    Console.WriteLine("Shutting Down...");
                }
                
            }
            while (value=="y" || value=="Y"); // Runs do whilst value is y either upper or lower case
    }
    
}
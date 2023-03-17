using System; //Calling system funtions
using System.Text; //Calling System subclasses if needed
using System.Threading.Tasks;
using System.Text.RegularExpressions;

public class Negative //setting class as Cylinder for program
{
     
    static void Main()
    {
        string restart;
            do // Running program through do so that program can be restarted
            {
                int count = 0; // number to start calculations at
                int guess = 0;
                int sCount = 0;
        
                Random rnd = new Random();
                int randomNumber = rnd.Next(0, 100); // generating the random number

                do {

                    if (guess < randomNumber && count >= 1) { // If guess is less than the random number
                        Console.WriteLine("Number is higher! Try again:");
                        
                    }
                    else if (guess > randomNumber && count >= 1) { // If more than random number
                        Console.WriteLine("Number is lower! Try Again");
                    }
                    else if (guess == 0) {
                        Console.WriteLine("Guess a number between 0 & 100:"); // Prompt for guess between 1 & 100
                    }
                    
                    string guessVerify = Console.ReadLine()!; // Getting input for number
                    bool IsNumber = int.TryParse(guessVerify, out guess); // checking if guess is a number
                    
                    while ( IsNumber == false && sCount < 7) { // if not a valid number ask for new inputs
                        Console.WriteLine("That's not a number! Try again:");

                        Console.WriteLine("Guess a number:");
                        guessVerify = Console.ReadLine()!;

                        IsNumber = int.TryParse(guessVerify, out guess); // revalidating input
                        sCount++;
                    }
                    count++;
                    int attempts = 7 - count;
                    Console.WriteLine("Attempts taken " + count); // Outputs the attemps to the user
                    Console.WriteLine("Attempts left " + attempts);
                    Console.WriteLine("");
                    
                    if (guess == randomNumber) { // If guess is correct
                    Console.WriteLine("Correct! Random number was " + randomNumber);
                    }
                    else if (count == 7 || sCount == 7) {
                        Console.WriteLine("Number was " + randomNumber); // If not guessed in 7 tries it outputts correct answer
                    }
                }
                while(guess != randomNumber && count < 7 && sCount < 7);

                Console.Write("Do you want to do play again?(y/n):");
                restart = Console.ReadLine()!;
                if (restart == "y" || restart == "Y") {
                    Console.WriteLine("Continuing...");
                }
            }
            while (restart == "Y" || restart == "y"); // Program will restart as long as value is equal to Y/y from the start of the do
           
            
    }
}
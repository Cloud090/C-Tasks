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
                int guess;
        
                Random rnd = new Random();
                int randomNumber = rnd.Next(0, 100); // generating 7 storing the random number

                
                Console.WriteLine("Guess a number between 0 & 100:"); // Prompt for guess between 1 & 100
                string guessVerify = Console.ReadLine(); // Getting input for number

                bool IsNumber = int.TryParse(guessVerify, out guess); // checking if guess is a number

                while ( IsNumber == false) { // if not a valid number ask for new inputs
                    Console.WriteLine("That's not a number! Try again:");

                    Console.WriteLine("Guess a number:");
                    guessVerify = Console.ReadLine()!;

                    IsNumber = int.TryParse(guessVerify, out guess); // revalidating input
                }
                
                
                count++; // Adding 1 to count
                while (guess != randomNumber && count<7) { // Enteres loop whilst guess is incorrect & there are guesses left
                    int attempts = 7 - count;
                    Console.WriteLine("Attempts taken " + count); // Outputs the attemps to the user
                    Console.WriteLine("Attempts left " + attempts);
                    
                    if (guess < randomNumber) { // If guess is less than the random number
                        Console.WriteLine("Number is higher! Try again:");
                        guessVerify = Console.ReadLine(); // Takes new input

                        IsNumber = int.TryParse(guessVerify, out guess); // checking if guess is a number

                        while ( IsNumber == false) { // if not a valid number ask for new inputs
                            Console.WriteLine("That's not a number! Try again:");

                            Console.WriteLine("Guess a number:");
                            guessVerify = Console.ReadLine()!;

                            IsNumber = int.TryParse(guessVerify, out guess); // revalidating input
                        }
                    }
                    else if (guess > randomNumber) { // If more than random number
                        Console.WriteLine("Number is lower! Try Again");
                        guessVerify = Console.ReadLine(); // Takes new input

                        IsNumber = int.TryParse(guessVerify, out guess); // checking if guess is a number

                        while ( IsNumber == false) { // if not a valid number ask for new inputs
                            Console.WriteLine("That's not a number! Try again:");

                            Console.WriteLine("Guess a number:");
                            guessVerify = Console.ReadLine()!;

                            IsNumber = int.TryParse(guessVerify, out guess); // revalidating input
                        }
                    }
                    count++; // Adding to count for every time it reenteres the loop for a new guess
                }
                if (guess == randomNumber) { // If guess is correct
                    Console.WriteLine("Correct! Random number was " + randomNumber);
                }
                else {
                    Console.WriteLine("Number was " + randomNumber); // If not guessed in 7 tries it outputts correct answer
                }

                Console.Write("Do you want to do play again?(y/n):");
                restart = Console.ReadLine()!;
                if (restart == "y" || restart == "Y") {
                    Console.WriteLine("Continuing...");
                }
            }
            while (restart == "Y" || restart == "y"); // Program will restart as long as value is equal to Y/y from the start of the do
           
    }
    
}
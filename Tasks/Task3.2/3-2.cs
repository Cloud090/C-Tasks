using System; // Declaring libaries to use
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

public class Pass
{
    static void Main()
    {
        Console.WriteLine("Password must contain at least 1: letter, number & symbol"); // Printing password requirements for the user to understand
        Console.WriteLine("Enter Password:"); // prompt to enter password
        string password = Console.ReadLine()!; // Taking user input saving as a string

        var hasNumber = new Regex(@"[0-9]+"); // Regex to check if a string has a number in it. Storing for password validation
        var hasUpperChar = new Regex(@"[A-Za-z]+"); // Regex to check if a string has a letter in it. Storing for password validation
        var incSymbol = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+"); // Regex to check if a string has a symbol in it. Storing for password validation
        var hasMinimum3Chars = new Regex(@".{3,}"); // Checking if the password has at least 3 characters which is required for it to have a letter,number & symbol

        int count = 0; // Starting count to track times password entered correctly
        var passRules = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && incSymbol.IsMatch(password)
        && hasMinimum3Chars.IsMatch(password); // Validating password entered by user using the earlier declared variables

        while (passRules == false) { // If password doesn't meet the rules it will enter this loop
            Console.WriteLine("Remember your password must contain at least 1: letter, number & symbol"); // Reminder of password requirements
            Console.WriteLine("Your password doesn't meet the requirements. Try Again: "); // Prompt
            Console.WriteLine("Enter Password:"); 
            password = Console.ReadLine()!; // Taking a new password input & overwriting the password vaiable
            passRules = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && incSymbol.IsMatch(password) 
            && hasMinimum3Chars.IsMatch(password); // Validating

        }
            count++; // Adding 1 to count once the password is entred & validated
            Console.WriteLine("Entered: " + count + " times correctly out of 3"); // Letting the user know of success & show how many more times password is needed 
            string passVerify; // variable to verify the password input
            do
            {
                Console.WriteLine("Enter Password:");
                passVerify = Console.ReadLine()!;
                if (passVerify == password){ // Verifying the password entered for the 2 & 3 time match the first input
                    count++; // Adding 1 to count if sucessful
                    Console.WriteLine("Entered: " + count + " times correctly out of 3"); // Output for correct input to the user
                }
                else {
                    Console.WriteLine("Goodbye"); // Printing goodbye to let the user know the program is exiting after an incorrect password attempt
                    continue;
                }
                
                Console.WriteLine(count); // Printing the count of attempts

                if (count == 3) { // Once password is printed 3 times correctly prints welcome
                    Console.WriteLine("Welcome");
                }
            }
            
            while (passVerify == password & count<3); // If password is correct & password entered less than 3 times it will restart the do
    }
    
}
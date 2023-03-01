using System;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

public class Password
{
    static void Main()
    {
        Console.WriteLine("Password must contain at least 1: letter, number & symbol");
        Console.WriteLine("Enter Password:");
        string password = Console.ReadLine()!;

        var hasNumber = new Regex(@"[0-9]+");
        var hasUpperChar = new Regex(@"[A-Za-z]+");
        var incSymbol = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+");
        var hasMinimum3Chars = new Regex(@".{3,}");

        int count = 0;
        var passRules = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && incSymbol.IsMatch(password) 
        && hasMinimum3Chars.IsMatch(password);

        while (passRules == false) {
            Console.WriteLine("Remember your password must contain at least 1: letter, number & symbol");
            Console.WriteLine("Your password doesn't meet the requirements. Try Again: ");
            Console.WriteLine("Enter Password:");
            password = Console.ReadLine()!;
            passRules = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && incSymbol.IsMatch(password) 
            && hasMinimum3Chars.IsMatch(password);

        }
            count++;
            Console.WriteLine("Entered: " + count + " times correctly out of 3");
            string passVerify;
            do
            {
                Console.WriteLine("Enter Password:");
                passVerify = Console.ReadLine();
                if (passVerify == password){
                    count++;
                    Console.WriteLine("Entered: " + count + " times correctly out of 3");
                }
                else {
                    Console.WriteLine("Goodbye");
                    continue;
                }
                
                Console.WriteLine(count);

                if (count == 3) {
                    Console.WriteLine("welcome");
                }
            }
            
            while (passVerify == password & count<3);
    }
    
}
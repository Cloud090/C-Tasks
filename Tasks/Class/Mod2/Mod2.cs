using System; //Calling system funtions
using System.Text; //Calling System subclasses if needed
using System.Threading.Tasks;

public class Cylinder //setting class as Cylinder for program
{
     
    static void Main()
    {
        string value; // storing value for program restart y/n
            do // Running program through do so that program can be restarted
            {
                
                double fahrenheit; // Setting fahrenheit variable & setting as double which can store 8 bytes enough to prevent data overflows
                double celsius; // Setting celsius value for output

                Console.WriteLine("Enter Fahrenheit!"); // Printing a promt for user input
                fahrenheit = double.Parse(Console.ReadLine()); // Reading user input, storing in fahrenheit and converting user input to double data type
                Console.WriteLine("Fahrenheit is " + fahrenheit); // Outputting user entred data to tell the user the input the program has registered

                celsius = (fahrenheit - 32)*5/9; // Calculating the temprature in celsius & storing in celsius variable
                
                Console.WriteLine("Temprature in Celsius is: " + celsius); // Outputting the celsius temp calculated to the user
                
                Console.Write("Do you want to do another caconversion?(y/n):"); // promt to calculate another temp
                value = Console.ReadLine()!;

                if (value == "y" || value == "Y") { // If user types y/Y it will print continue as feedback to the user
                    Console.WriteLine("Continuing...");
                }
                else {
                    Console.WriteLine("Shutting down. . ."); // if input was anything other than y/Y it will end the program
                }
                
                
            }
            while (value=="y" || value=="Y"); // Program will restart as long as value is equal to Y/y from the start of the do
    }
    
}
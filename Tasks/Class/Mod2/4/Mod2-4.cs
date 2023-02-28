using System; //Calling system funtions
using System.Text; //Calling System subclasses if needed
using System.Threading.Tasks;

public class Cylinder //setting class as Cylinder for program
{
     
    static void Main()
    {
        int value = 0; // Counting how many times the number is outputted
        int num; // Setting variable for number input

        Console.WriteLine("Enter a number:"); // User promt
        num = Convert.ToInt32(Console.ReadLine()); // Reading input & saving to num
            do // Running program through do so that program can be restarted
            {
                
                

                Console.WriteLine("{0} {0} {0} {0}", num); // outputting the num spaced out 4 times in a row

                Console.Write(num); // soutputting the num 4 times without spacing
                Console.Write(num);
                Console.Write(num);
                Console.Write(num);
                Console.WriteLine(""); // Adding a space for the next run
                value++; // adding 1 to the value variable
            }
            while (value < 2); // Program will end after the second loop
    }
    
}
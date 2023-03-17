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
                int[] array = new int[5] {1, 2, 3, 4, 5};

                for (int i = 0; i < array.length(array[i])) {
                    Console.WriteLine(array[i]);
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
using System;
using System.Text;
using System.Threading.Tasks;

public class Password
{
    static void Main()
    {
        string password;
            int count = 0;
            do
            {

                Console.WriteLine("Enter Password:");
                password = Console.ReadLine()!;
                if (password =="Password123!"){
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
            
            while (password=="Password123!" & count<3);
    }
    
}



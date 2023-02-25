using System;
using System.Text;
using System.Threading.Tasks;

public class Grade
{
    static void Main()
    {
        string value;
            do
            {

                Console.WriteLine("Score:");
                int Score = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Score is: " + Score);

                if (Score >= 0 & Score <= 100) {
                    

                    if (Score >= 85 & Score <= 100) {
                        Console.WriteLine(Score +" = High Distinction");  
                    }
                    if (Score >= 75 & Score <= 84) {
                        Console.WriteLine(Score + " = Distinction");
                    }
                    if (Score >= 65 & Score <= 74){
                        Console.WriteLine(Score +" = Credit");
                    }
                    if (Score >= 55 & Score <=64) {
                        Console.WriteLine(Score +" = Pass");
                    }
                    if (Score >= 0 & Score <= 54) {
                        Console.WriteLine(Score +" = Fail");
                    }
                }
                else {
                    Console.WriteLine("Invalid");
                }
                
                
                Console.Write("Do you want to do input another score?(y/n):");
                value = Console.ReadLine()!;
                if (value =="y" ||value=="Y"){
                    Console.WriteLine("Continuing...");
                }
                else {
                    Console.WriteLine("Shutting Down...");
                }
                
            }
            while (value=="y" || value=="Y");
    }
    
}



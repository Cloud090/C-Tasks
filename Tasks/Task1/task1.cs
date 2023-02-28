using System;
using System.Text;
using System.Threading.Tasks;

public class Calculator
{
     
    static void Main()
    {
        string value;
            do
            {
                
                Console.WriteLine ("Input 1:");
                string input1Verify = Console.ReadLine()!;
                int input1;
                

                bool isNumerical = int.TryParse(input1Verify, out input1);

                while (isNumerical == false) {
                    Console.WriteLine("Oh no, that's not a number! Try Again:");
                    input1Verify = Console.ReadLine()!;
                    isNumerical = int.TryParse(input1Verify, out input1);
                }
                Console.WriteLine("First Input is: " + input1);

                Console.WriteLine ("Input 2:");
                string input2Verify = Console.ReadLine()!;
                int input2;

                bool isNumerical2 = int.TryParse(input2Verify, out input2)!;

                while (isNumerical2 == false) {
                    Console.WriteLine("Oh no, that's not a number! Try Again:");
                    input2Verify = Console.ReadLine()!;
                    isNumerical2 = int.TryParse(input2Verify, out input2);
                }
                Console.WriteLine("Second Input is: " + input2);
                
                int multiply = input1 * input2; //Multiplying inputted numbers
                int add = input1 + input2; // Adding Inputted numbers
                int subtract = input1 - input2; //Subtracting Inputted numbers
                int divide = input1 / input2; // Dividing inputted numbers
                
                Console.WriteLine("Results:"); //Labeling the following as the results clearly
                Console.WriteLine("Multiplication: " + input1 + " X " + input2 + " = " + multiply); //Displaying maths method & user inputs with answers for multiplication,subtraction,addition & division
                Console.WriteLine("Addition: " + input1 + " + " + input2 + " = " + add);
                Console.WriteLine("Subtraction: " + input1 + " - " + input2 + " = " + subtract);
                Console.WriteLine("Division: " + input1 + " / " + input2 + " = " + divide);
                
                
                Console.Write("Do you want to do another calculation?(y/n):");
                value = Console.ReadLine()!;
                if (value == "y" || value == "Y") {
                    Console.WriteLine("Continuing...");
                }
                else {
                    Console.WriteLine("Shutting down. . .");
                }
                
                
            }
            while (value=="y" || value=="Y");
    }
    
}
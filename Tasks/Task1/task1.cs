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
                int multiply;
                int add;
                int subtract;
                int divide;

                
                /* Console.WriteLine ("Input 1:");
                int Input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("First Input is: " + Input1);

                Console.WriteLine ("Input 2:");
                int Input2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second Input is: " + Input2); */

                Console.WriteLine ("Input 1:");
                string input1Verify = Console.ReadLine();
                int Input1;
                

                bool isNumerical = int.TryParse(input1Verify, out Input1);

                while (isNumerical == false) {
                    Console.WriteLine("Oh no, that's not a number! Try Again:");
                    input1Verify = Console.ReadLine();
                    isNumerical = int.TryParse(input1Verify, out Input1);
                }
                Console.WriteLine("First Input is: " + Input1);

                Console.WriteLine ("Input 2:");
                string input2Verify = Console.ReadLine();
                int Input2;

                bool isNumerical2 = int.TryParse(input2Verify, out Input2);

                while (isNumerical2 == false) {
                    Console.WriteLine("Oh no, that's not a number! Try Again:");
                    input2Verify = Console.ReadLine();
                    isNumerical2 = int.TryParse(input2Verify, out Input2);
                }
                Console.WriteLine("Second Input is: " + Input2);
                
                multiply = Input1 * Input2; //Multiplying inputted numbers
                add = Input1 + Input2; // Adding Inputted numbers
                subtract = Input1 - Input2; //Subtracting Inputted numbers
                divide = Input1 / Input2; // Dividing inputted numbers
                
                Console.WriteLine("Results:"); //Labeling the following as the results clearly
                Console.WriteLine("Multiplication: " + Input1 + " X " + Input2 + " = " + multiply); //Displaying maths method & user inputs with answers for multiplication,subtraction,addition & division
                Console.WriteLine("Addition: " + Input1 + " + " + Input2 + " = " + add);
                Console.WriteLine("Subtraction: " + Input1 + " - " + Input2 + " = " + subtract);
                Console.WriteLine("Division: " + Input1 + " / " + Input2 + " = " + divide);
                
                
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
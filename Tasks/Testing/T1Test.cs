using System;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

                Console.WriteLine ("Operation for calculation: (*, /,  +, -)");
                string operationType = Console.ReadLine();
                

                while (!operationType.Equals ("*") && !operationType.Equals ("/") && !operationType.Equals ("+") && !operationType.Equals ("-"))
                {
                    Console.WriteLine ("Oh no, your input didn't contain an operation. Try Again: (*, /,  +, -)");
                    operationType = Console.ReadLine();
                }   
                Console.WriteLine("Operation is: " + operationType);     

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

                Console.WriteLine("Results:"); //Labeling the following as the results clearly
                if (operationType.Equals ("*")) {
                    multiply = Input1 * Input2; //Multiplying inputted numbers
                    Console.WriteLine("Multiplication: " + Input1 + " X " + Input2 + " = " + multiply); //Displaying maths method & user inputs with answers for multiplication,subtraction,addition & division
                }
                if (operationType.Equals ("/")) {
                    divide = Input1 / Input2; // Dividing inputted numbers
                    Console.WriteLine("Division: " + Input1 + " / " + Input2 + " = " + divide); 
                }
                if (operationType.Equals ("+")) {
                    add = Input1 + Input2; // Adding Inputted numbers
                    Console.WriteLine("Addition: " + Input1 + " + " + Input2 + " = " + add);
                }
                if (operationType.Equals ("-")) {
                    subtract = Input1 - Input2; //Subtracting Inputted numbers
                    Console.WriteLine("Subtraction: " + Input1 + " - " + Input2 + " = " + subtract);
                }
                
                
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

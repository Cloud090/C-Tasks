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

                Console.WriteLine("Operation Type: (*,+,-,/)");
                string operation = Console.ReadLine();
                
            while (string.IsNullOrEmpty(operation))
            {
                Console.WriteLine("Operation type can't be empty! Input the operation type once more:");
                name = Console.ReadLine();
            }              

                Console.WriteLine ("Input 1:");
                int Input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("First Input is: " + Input1);

                Console.WriteLine ("Input 2:");
                int Input2 = Convert.ToInt32(Console.ReadLine());
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
                if (value = "y") {
                    Console.WriteLine("Continuing...");
                }
                else {
                    Console.WriteLine("Shutting down. . .");
                }
                
                
            }
            while (value=="y" || value=="Y");
    }
    
}

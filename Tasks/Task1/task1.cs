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
                int Add;
                int Subtract;
                int Divide;

                
                Console.WriteLine ("Input 1:");
                int Input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("First Input is: " + Input1);

                Console.WriteLine ("Input 2:");
                int Input2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second Input is: " + Input2);
                
                multiply = Input1 * Input2; //Multiplying inputted numbers
                Add = Input1 + Input2; // Adding Inputted numbers
                Subtract = Input1 - Input2; //Subtracting Inputted numbers
                Divide = Input1 / Input2; // Dividing inputted numbers
                
                Console.WriteLine("Results:"); //Labeling the following as the results clearly
                Console.WriteLine("Multiplication: " + Input1 + " X " + Input2 + " = " + multiply); //Displaying maths method & user inputs with answers for multiplication,subtraction,addition & division
                Console.WriteLine("Addition: " + Input1 + " + " + Input2 + " = " + Add);
                Console.WriteLine("Subtraction: " + Input1 + " - " + Input2 + " = " + Subtract);
                Console.WriteLine("Division: " + Input1 + " / " + Input2 + " = " + Divide);
                
                
                Console.Write("Do you want to do another calculation?(y/n):");
                value = Console.ReadLine()!;
                Console.WriteLine("Continuing...");
                
            }
            while (value=="y" || value=="Y");
    }
    
}
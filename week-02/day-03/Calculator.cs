using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations:
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit

            // UserInput(string what, int n1, int n2);

            string what;

            Console.WriteLine("Please type in the expression: (i.e.: + 3 3)");
            what = Console.ReadLine();
            string[] userinputs = what.Split(' ');
            
            float num1 = float.Parse(userinputs[1]);
            float num2 = float.Parse(userinputs[2]);
            
            
            switch (userinputs[0])
            {
                case ("+"): 
                    Add(num1, num2);
                    break;
                case "-":
                    Subtract(num1, num2);
                    break;
                case "*":
                    Multiply(num1, num2);
                    break;
                case "/":
                    Divide(num1, num2);
                    break;
                case "%":
                    Percentage(num1, num2);
                    break;
                default: Console.WriteLine("Could you check your input please?");
                    break;
            } 
            

            Console.ReadLine();
        }    

        public static void Add (float num1 , float num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void Subtract(float num1, float num2)
        {
            Console.WriteLine(num1 - num2);
        }

        public static void Multiply(float num1, float num2)
        {
            Console.WriteLine(num1 * num2);
        }

        public static void Divide(float num1, float num2)
        {
            Console.WriteLine(num1 / num2);
        }

        public static void Percentage(float num1, float num2)
        {
            Console.WriteLine((num1 / num2) * 100);
        }
    }
}
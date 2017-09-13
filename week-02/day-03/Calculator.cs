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

            /*foreach (var userinput in userinputs)
            {
                Console.WriteLine(userinput);
            }*/


            string operation = userinputs[0];
            int num1 = Int32.Parse(userinputs[1]);
            int num2 = Int32.Parse(userinputs[2]);

            Console.WriteLine(operation);

            switch (userinputs[0])
            {
                case "+":
                case "-":
                case "*":
                case ":":
                default:
                    break;
            }
        
            Console.ReadLine();
        }    

        public static void Add (int num1 , int num2)
        {
            Console.WriteLine(num1 + num2);
        }

    }
}
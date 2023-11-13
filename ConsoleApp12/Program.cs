using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;

namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation: ");

                // Task 1. Read choice input and assing it to new int variable

                string s = Console.ReadLine();
                int s1 = int.Parse(s);

                // Task 2. Check if user selected choice 5. If so then exit the loop
                if (s1 == 5)
                {
                    break;
                }
                Console.Write("Enter first number: ");

                // Task 3. Get the first number and assing it to new double variable

                string s2 = Console.ReadLine();
                double fnum = double.Parse(s2);

                Console.Write("Enter second number: ");
                // Task 4. Get the second number and assing it to new double variable

                string s3 = Console.ReadLine();
                double snum = double.Parse(s3);

                // Task 5. Create double variable for default result value and assign it to be 0

                double def = 0;

                // Task 6. Handle choices using switch statement
                // Task 6.1 For each case create new function/method an call it inside the case
                //          - Case 1: Add 
                //          - Case 2: Subtract
                //          - Case 3: Multiply
                //          - Case 4: Divide, Note remeber to handle 0
                // Note: Think what the default choice should be
                // Note: Declare each case function/method outside Main method
                //       There is comment below where you can place your methods

                // Task 7. Print out the result
                if (s1 == 1)
                {
                    double result1 = Additional(fnum, snum);
                    Console.WriteLine($"This is your result {result1}");

                }
                if (s1 == 2)
                {
                    double result2 = Subtract(fnum, snum);
                    Console.WriteLine($"This is your result {result2}");
                }
                if (s1 == 3)
                {
                    double result3 = Multiply(fnum, snum);
                    Console.WriteLine($"This is your result {result3}");
                }
                if (s1 == 4)
                {
                    if (snum == 0)
                    {
                        Console.WriteLine($"This is your result {def}");
                    }
                    else
                    {
                        double result4 = Div(fnum, snum);
                        Console.WriteLine($"This is your result {result4}");
                    }
                }

            }
        }
        
        // Declare your methods/functions here
        public static double Additional(double fnum, double snum)
        {
            double sum = fnum + snum;
            return sum;
        }

        public static double Subtract(double fnum, double snum)
        {
            double sub = fnum - snum;
            return sub;
        }
        public static double Multiply(double fnum, double snum)
        {
            double mult = fnum * snum;
            return mult;
        }
        public static double Div(double fnum, double snum)
        {
            double div = fnum / snum;
            return div;
        }
    }
}

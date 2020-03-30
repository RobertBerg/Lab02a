using System;

namespace Lab02a
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1; // declare first number to add
            int number2; // declare second number to add
            int sum; // declare sum of number1 and number2
            
                Console.Write("Enter first integer: "); // prompt user
                // read first number from user
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second integer: "); // prompt user
                // read second number from user
                number2 = Convert.ToInt32(Console.ReadLine());

                sum = number1 + number2; // add numbers

                Console.WriteLine("Sum is {0}", sum); // display sum
            } // end Main
        } // end class Program

    }





    
using System.Diagnostics.Metrics;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Personal Info Card


            ///////////////////////////////


            //Task 2- Rectangle Calculator
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Area of the rectangle: " + (length * width), "Perimeter = 2 * (length * width)");
            ///////////////////////////////////

            //Task 3- Even or Odd Checker
            Console.WriteLine("Enter a Whole Number :");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even.");
            }
            else if (number % 2 == 1)
            {
                Console.WriteLine("The number is Odd.");
            }
            else
            {
                Console.WriteLine("The number is neither Even nor Odd.");
                //}
                //////////////////////////
                //Task 4-  Voting Eligibility
                Console.WriteLine("Enter your age : ");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Do you have a valid national identity card ? (true/false) : ");
                bool hasIDCard = bool.Parse(Console.ReadLine());

                if (age >= 18 && hasIDCard)
                {
                    Console.WriteLine("You are eligible to vote.");
                }
                else if (age <= 18 && hasIDCard)
                {
                    Console.WriteLine("You are not eligible to vote.");
                }
                else
                {
                    Console.WriteLine("You are not eligible to vote.");


                    //}
                    //////////////////////////////
                    //Task 5 - Grade Letter Lookup
                    Console.WriteLine("Enter a single character grade letter ('A', 'B' , 'C' , 'D' OR 'F'): ");
                    String gradeLetter = Console.ReadLine().ToUpper();

                    if (gradeLetter == "A")
                    {
                        Console.WriteLine("Excellent");
                    }
                    else if (gradeLetter == "B")
                    {
                        Console.WriteLine("Good");
                    }
                    else if (gradeLetter == "C")
                    {
                        Console.WriteLine("Average");
                    }
                    else if (gradeLetter == "D")
                    {
                        Console.WriteLine("Below Average");
                    }
                    else if (gradeLetter == "F")
                    {
                        Console.WriteLine("Failing");
                    }
                    else
                    {
                        Console.WriteLine("Invalid grade letter.");

                    }
                    ///////////////////////////////
                    // Task 6- Temperature Converter
                    //    Console.WriteLine("Enter a temperature in Celsius : ");
                    //    double celsius = double.Parse(Console.ReadLine());

                    //    Console.WriteLine("convert it to Fahrenheit :");
                    //    double fahrenheit = (celsius * 9 / 5) + 32;

                    //    if (fahrenheit < 10)
                    //    {
                    //        Console.WriteLine("The temperature is Cold");
                    //    }
                    //    else if (fahrenheit <= 10 && fahrenheit <= 30)
                    //    {
                    //        Console.WriteLine("The temperature is Mild.");
                    //    }
                    //    else if (fahrenheit >= 30)
                    //    {
                    //        Console.WriteLine("The temperature is Hot.");
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("The temperature is above boiling point.");
                    //}
                }

            }
}
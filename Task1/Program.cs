using System.Diagnostics.Metrics;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Task 1 - Personal Info Card


            /////////////////////////////////


            ////Task 2- Rectangle Calculator
            //Console.WriteLine("Enter the length of the rectangle: ");
            //double length = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the width of the rectangle: ");
            //double width = double.Parse(Console.ReadLine());

            //Console.WriteLine("Area of the rectangle: " + (length * width), "Perimeter = 2 * (length * width)");
            /////////////////////////////////////

            ////Task 3- Even or Odd Checker
            //Console.WriteLine("Enter a Whole Number :");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is Even.");
            //}
            //else if (number % 2 == 1)
            //{
            //    Console.WriteLine("The number is Odd.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is neither Even nor Odd.");
            //    //}
            //    //////////////////////////
            //    //Task 4-  Voting Eligibility
            //    Console.WriteLine("Enter your age : ");
            //    int age = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Do you have a valid national identity card ? (true/false) : ");
            //    bool hasIDCard = bool.Parse(Console.ReadLine());

            //    if (age >= 18 && hasIDCard)
            //    {
            //        Console.WriteLine("You are eligible to vote.");
            //    }
            //    else if (age <= 18 && hasIDCard)
            //    {
            //        Console.WriteLine("You are not eligible to vote.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are not eligible to vote.");


            //        //}
            //        //////////////////////////////
            //        //Task 5 - Grade Letter Lookup
            //        Console.WriteLine("Enter a single character grade letter ('A', 'B' , 'C' , 'D' OR 'F'): ");
            //        String gradeLetter = Console.ReadLine().ToUpper();

            //        if (gradeLetter == "A")
            //        {
            //            Console.WriteLine("Excellent");
            //        }
            //        else if (gradeLetter == "B")
            //        {
            //            Console.WriteLine("Good");
            //        }
            //        else if (gradeLetter == "C")
            //        {
            //            Console.WriteLine("Average");
            //        }
            //        else if (gradeLetter == "D")
            //        {
            //            Console.WriteLine("Below Average");
            //        }
            //        else if (gradeLetter == "F")
            //        {
            //            Console.WriteLine("Failing");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid grade letter.");

            //        }
            //        ///////////////////////////////
            //        // Task 6- Temperature Converter
            //        Console.WriteLine("Enter a temperature in Celsius : ");
            //        double celsius = double.Parse(Console.ReadLine());

            //        Console.WriteLine("convert it to Fahrenheit :");
            //        double fahrenheit = (celsius * 9 / 5) + 32;

            //        if (fahrenheit < 10)
            //        {
            //            Console.WriteLine("The temperature is Cold");
            //        }
            //        else if (fahrenheit <= 10 && fahrenheit <= 30)
            //        {
            //            Console.WriteLine("The temperature is Mild.");
            //        }
            //        else if (fahrenheit >= 30)
            //        {
            //            Console.WriteLine("The temperature is Hot.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("The temperature is above boiling point.");
            //        }
            ////////////////////////////
            //Task 7- Movie Ticket Pricing
            //some code to solvr problem
            //Console.WriteLine("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //double price;
            //string category;

            //if (age >= 0 && age <= 12)
            //{
            //    category = "Children";
            //    price = 2.000;
            //}
            //else if (age >= 13 && age <= 59)
            //{
            //    category = "Adults";
            //    price = 5.000;
            //}
            //else if (age >= 60)
            //{
            //    category = "Seniors";
            //    price = 3.000;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid age entered.");
            //    return;
            //}

            //Console.WriteLine($"{category} — Price: {price.ToString("F3")} OMR");

            ////////////////////////////
            //Task 8-  Restaurant Bill with Membership Discount
            //some code to solvr problem

            //Console.WriteLine("Enter your total bill amount (OMR): ");
            //double totalBill = double.Parse(Console.ReadLine());


            //Console.WriteLine("Are you a loyalty member? (yes/no): ");
            //string memberInput = Console.ReadLine().Trim().ToLower();


            //bool isMember = (memberInput == "yes" || memberInput == "true");

            //double discount = 0;


            //if (totalBill > 20 && isMember)
            //{
            //    discount = totalBill * 0.15;
            //}
            //else
            //{
            //    discount = 0;
            //}
            //double finalAmount = totalBill - discount;

            //Console.WriteLine("\n--- Receipt ---");
            //Console.WriteLine($"Original Bill:   {totalBill:F3} OMR");
            //Console.WriteLine($"Discount Amount: {discount:F3} OMR");
            //Console.WriteLine($"Final Amount:    {finalAmount:F3} OMR");

            ////////////////////////////
            //Task 9-   Day Name Finder
            //some code to solvr problem
            //Console.WriteLine("Enter a number (1-7) to find the corresponding day of the week: ");
            //int dayNumber = int.Parse(Console.ReadLine());

            //int day = 1;
            //switch (dayNumber)
            //{
            //    case 1:
            //        Console.WriteLine("The day is Sunday.");
            //        break;
            //    case 2:
            //        Console.WriteLine("The day is Monday.");
            //        break;
            //    case 3:
            //        Console.WriteLine("The day is Tuesday.");
            //        break;
            //    case 4:
            //        Console.WriteLine("The day is Wednesday.");
            //        break;
            //    case 5:
            //        Console.WriteLine("The day is Thuersday.");
            //        break;
            //    case 6:
            //        Console.WriteLine("The day is Friday.");
            //        break;
            //    case 7:
            //        Console.WriteLine("The day is Saturday.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            //        break;


            ////////////////////////////
            //Task 10-    Mini Calculator
            //some code to solvr problem
            //Console.WriteLine("Enter First Number : ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter an operator (+, -, *, /): ");
            //char op = char.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Second Number :");
            //int num2 = int.Parse(Console.ReadLine());

            //switch (op)
            //{
            //    case '+':
            //        Console.WriteLine("Addition: " + (num1 + num2));
            //        break;
            //    case '-':
            //        Console.WriteLine("Subtraction: " + (num1 - num2));
            //        break;
            //    case '*':
            //        Console.WriteLine("Multiplication: " + (num1 * num2));
            //        break;
            //    case '/':
            //        Console.WriteLine("Divition: " + (num1 / num2));
            //        break;
            //    default:
            //        Console.WriteLine("Unknown operator. Please enter a valid operator (+, -, *, /).");
            //        break;

            ////////////////////////////
            //Task 11-    Loan Eligibility System
            //some code to solvr problem

            //Console.WriteLine("Enter your Age : ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your Monthly : ");
            //int monthlyIncome = int.Parse(Console.ReadLine());

            //Console.WriteLine("Do you have a current loan? (true/false) : ");
            //bool hasCurrentLoan = bool.Parse(Console.ReadLine());

            //if (age >= 21 && age <= 60 && monthlyIncome >= 400 && !hasCurrentLoan)
            //{
            //    Console.WriteLine("You are eligible for a loan.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible for a loan.");


            //}
            ////////////////////////////
            //Task 12-    Shipping Cost Calculator
            //some code to solvr problem

            //Console.WriteLine("Enter a region code ('A' for local , 'B' for national AND 'C' for international): ");
            //char regionCode = char.Parse(Console.ReadLine().ToUpper());

            //switch (regionCode)
            //{
            //    case 'A':
            //        Console.WriteLine("Shipping cost for local region is 1.000 OMR.");
            //        break;
            //    case 'B':
            //        Console.WriteLine("Shipping cost for local region is 3.000 OMR.");
            //        break;
            //    case 'C':
            //        Console.WriteLine("Shipping cost for local region is 7.000 OMR.");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown region code. Please enter a valid region code ('A', 'B', or 'C').");
            //        break;
            //}

            ////////////////////////////
            //Task 13-    Triangle Type Classifier
            //some code to solvr problem
            //Console.WriteLine("Enter the length of the first side of the triangle: ");
            //double side1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the length of the second side of the triangle: ");
            //double side2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the length of the third side of the traiangle: ");
            //double side3 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Doed it form a triangle? (true/false) : if true classify its type");
            //bool isTriangle = bool.Parse(Console.ReadLine());

            //if ((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1))

            //{
            //    Console.WriteLine("\nThese sides form a valid triangle.");


            //    if (side1 == side2 && side2 == side3)
            //    {
            //        Console.WriteLine("Type: Equilateral (all sides are equal).");
            //    }
            //    else
            //    {

            //        if (side1 == side2 || side1 == side3 || side2 == side3)
            //        {
            //            Console.WriteLine("Type: Isosceles (exactly two sides are equal).");
            //        }
            //        else
            //        {

            //            Console.WriteLine("Type: Scalene (all sides are different).");
            //        }
            //    }
            //}
            //else
            //{

            //    Console.WriteLine("\nError: These lengths do not form a valid triangle.");
            //}

            ////////////////////////////
            //Task 14-    Online Store Checkout
            //some code to solvr problem
            //Console.WriteLine("Enter your product code ( 1 , 2 OR 3 ) :");
            //int Procode = int.Parse(Console.ReadLine());

            //Console.WriteLine("Do you have a discount coupon? (yes/no) : ");
            //bool hasCoupon = Console.ReadLine().Trim().ToLower() == "yes";

            //string Tools = "";
            //double Price = 0;


            //switch (Procode)
            //{
            //    case 1:
            //        Tools = "Headphones";
            //        Price = 8.500;
            //        break;
            //    case 2:
            //        Tools = "Keyboard";
            //        Price = 5.000;
            //        break;
            //    case 3:
            //        Tools = "Mouse";
            //        Price = 5.000;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid product code. Please enter a valid product code (1, 2, or 3).");
            //        break;
            //}


            //if (Procode >= 1 && Procode <= 3)
            //{
            //    double finalPrice = Price;


            //    if (hasCoupon)
            //    {
            //        double discount = Price * 0.10;
            //        finalPrice = Price - discount;
            //        Console.WriteLine($"\nCoupon applied! You saved: {discount:F3}");
            //    }


            //    Console.WriteLine("--- Receipt ---");
            //    Console.WriteLine($"Product: {Tools}");
            //    Console.WriteLine($"Original Price: {Price:F3}");
            //    Console.WriteLine($"Final Amount to Pay: {finalPrice:F3}");
            //}


            ////////////////////////////
            //Task 15-     University Admission Decision
            //some code to solvr problem

            Console.WriteLine("Enter program type ('S' for Science, 'A' for Arts): ");
            char programType = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("Enter your application score (0-4.0): ");
            double applicationScore = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your entrance exam score (0-100): ");
            double entranceExamScore = double.Parse(Console.ReadLine());

            Console.WriteLine("Do you have any extracurricular achievements? (yes/no): ");
            bool hasExtracurricular = Console.ReadLine().Trim().ToLower() == "no";

            switch (programType)
            {
                case 'A':
                    if (applicationScore >= 3.5 && entranceExamScore >= 75)
                    {
                        Console.WriteLine("Congratulations! You are admitted to the Science program.");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you do not meet the admission criteria for the Science program.");
                    }
                    break;
                default:
                    Console.WriteLine("Unknown program type. Please enter 'S' for Science or 'A' for Arts.");
                    break;

            }
        }
    }
}


    



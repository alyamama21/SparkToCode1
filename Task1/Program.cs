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
            Console.WriteLine("Enter First Number : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an operator (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number :");
            int num2 = int.Parse(Console.ReadLine());

            

            
            switch (op)
                {
            case '+':
                    Console.WriteLine("Addition: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Subtraction: " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication: " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Divition: " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Unknown operator. Please enter a valid operator (+, -, *, /).");
                    break;



                }
            }

        }
    }



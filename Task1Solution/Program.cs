namespace Task1Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-Personal info card
            //some code to solve problem
            ///////////////////////////////
            //Console.WriteLine(" Enter Your Name: ");
            //string userName = Console.ReadLine();

            //Console.WriteLine("Enter Your Age: ");
            //int userAge = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Your Hight: ");
            //double userHeight = double.Parse(Console.ReadLine());

            //Console.Write("Are you a student? (true/false): ");
            //bool isStudent = bool.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("---Personal Info Card---");
            //Console.WriteLine($" Name: {userName} " +
            //    $" Age: {userAge}" +
            //    $" Hight: {userHeight} " +
            //    $" Status: Student ");

            ///////////////////////////////
            //2-Rectangle Calculator
            //some code to solve problem
            //Console.WriteLine("Enter the length of the rectangle: ");
            //double length = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the width of the rectangle: ");
            //double width = double.Parse(Console.ReadLine());

            //Console.WriteLine("Area of the rectangle: " + (length * width), "Perimeter = 2 * (length * width)");
            ///////////////////////////////
            //3-Even or Odd Checker
            //some code to solve problem
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

            //}
            ///////////////////////////////
            //4-Voting Eligibility
            //some code to solve problem
            //Console.WriteLine("Enter your age : ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Do you have a valid national identity card ? (true/false) : ");
            //bool hasIDCard = bool.Parse(Console.ReadLine());

            //if (age >= 18 && hasIDCard)
            //{
            //    Console.WriteLine("You are eligible to vote.");
            //}
            //else if (age <= 18 && hasIDCard)
            //{
            //    Console.WriteLine("You are not eligible to vote.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to vote.");
            //}
            ///////////////////////////////
            //5-Voting Eligibility
            //some code to solve problem
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
        }
    }
}

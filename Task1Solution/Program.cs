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

            }
        }
    }
}

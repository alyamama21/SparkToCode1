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
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Area of the rectangle: " + (length * width), "Perimeter = 2 * (length * width)");

        }
    }
}

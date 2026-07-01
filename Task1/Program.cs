namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Personal Info Card

            Console.WriteLine(" Enter Your Name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter Your Age: ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Hight: ");
            double userHeight = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false): ");
            bool isStudent = bool.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("---Personal Info Card---");
            Console.WriteLine($" Name: {userName} " + 
                $" Age: {userAge}" + 
                $" Hight: {userHeight} " + 
                $" Status: Student "); 
            
        }
    }
}

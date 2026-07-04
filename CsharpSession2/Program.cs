using System.Diagnostics.Metrics;

namespace CsharpSession2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitDecision = false;
            String userInput;

            do
            { 
            while (exitDecision == false)
            {
                Console.WriteLine("print menu");

                Console.WriteLine("Do you want to exit the program? (y/n)");
                userInput = Console.ReadLine();

                if (userInput == "y")
                {
                  
                        }exitDecision = true;
                }

            }
    }
}

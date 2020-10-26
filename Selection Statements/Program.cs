using System;

namespace Selection_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number.");
            
            int favNumber = 21;

            int userInput = int.Parse(Console.ReadLine());

            if (userInput > favNumber)
            {
                Console.WriteLine("Too High!");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Too Low!");
            }
            else
            {
                Console.WriteLine("Never mind.");
            }
        }
    }
}

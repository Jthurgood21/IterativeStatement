using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an Interger between 2 and 10: ");

            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);

            if (userNumber % 2 == 0)
            {
                for(int i = 1; i < userNumber + 2; i++)
                {
                    Console.WriteLine(i.ToString() + "." + "you entered an even number");
                }
            }
            else
            {
                for (int i = 1; i < userNumber + 0; i++)
                {
                    Console.WriteLine(i.ToString() + "." + "You entered an odd number");
                }

            }
        }
    }
}

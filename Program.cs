using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Interger: ");
            int userNumber;

            while (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.Clear();
                Console.WriteLine("Enter only a number please!");
            }
            
            if
        }
    }
}

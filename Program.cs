using System;
namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number from 1 to 4:");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        lb.Task1();
                        break;
                    case 2:
                        lb.Task2();
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        lb.Task4();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                        break;
                }
            }
        }

    }
}

